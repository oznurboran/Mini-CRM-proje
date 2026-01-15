using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMProjeyeni.Service;
using CRMProjeyeni.Domain;

namespace CRMProjeyeni.UI
{
    public partial class PersonelForm: Form
    {
        private PersonelService personelService = new PersonelService();
        public PersonelForm()
        {
            InitializeComponent();
        }
        private void AlanlariTemizle()
        {
            adtxtBox.Clear();
            soyadtxtBox.Clear();
            uzmanlikCmbbox.SelectedIndex = -1;
        }


        private void UzmanlikDoldur()
        {
            uzmanlikCmbbox.Items.Clear();
            uzmanlikCmbbox.Items.Add("CİLT BAKIM UZMANI");
            uzmanlikCmbbox.Items.Add("MAKYAJ UZMANI");
            uzmanlikCmbbox.Items.Add("EL & AYAK BAKIM UZMANI");
            uzmanlikCmbbox.Items.Add("MAKYAJ UZMANI");
        }
        




        private void PersonelForm_Load(object sender, EventArgs e)
        {
            Listele();
            UzmanlikDoldur();
        }

        private void Listele()
        {
            personellerDgv.DataSource = personelService.Listele();
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(adtxtBox.Text) ||
                string.IsNullOrWhiteSpace(soyadtxtBox.Text) ||
                uzmanlikCmbbox.SelectedIndex == -1)
            {
                MessageBox.Show("Tüm alanları doldurunuz");
                return;
            }

            Personel p = new Personel
            {
                AdSoyad = adtxtBox.Text.Trim() + " " + soyadtxtBox.Text.Trim(),
                Uzmanlik = uzmanlikCmbbox.SelectedItem.ToString()
            };

            personelService.Ekle(p);
            Listele();
            AlanlariTemizle();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            if (personellerDgv.CurrentRow == null)
            {
                MessageBox.Show("Silinecek personeli seçiniz");
                return;
            }

            int id = Convert.ToInt32(
                personellerDgv.CurrentRow.Cells["PersonelId"].Value
            );

            var sonuc = MessageBox.Show(
                "Seçili personel silinsin mi?",
                "Onay",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (sonuc == DialogResult.Yes)
            {
                personelService.Sil(id);
                Listele();
                AlanlariTemizle();
            }
        }

        private void personellerDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = personellerDgv.Rows[e.RowIndex];

            string adSoyad = row.Cells["AdSoyad"].Value.ToString();
            var parca = adSoyad.Split(' ');

            adtxtBox.Text = parca[0];
            soyadtxtBox.Text = parca.Length > 1 ? parca[1] : "";
            uzmanlikCmbbox.SelectedItem = row.Cells["Uzmanlik"].Value.ToString();
        }

        private void uzmanlikCmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }

}
