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
    public partial class MusteriForm: Form
    {
        private MusteriService musteriService = new MusteriService();

        private void Temizle()
        {
            adTxtbox.Clear();
           
            epostaTxtbox.Clear();
            telefonTxtbox.Clear();
           
        }

        public MusteriForm()
        {
            InitializeComponent();
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
      

        private void Listele()
        {
            musteriDgv.DataSource = musteriService.Listele();
        }

        private void yenimusteriolusturButton_Click(object sender, EventArgs e)
        {
            string ad = adTxtbox.Text.Trim();
           

            if (string.IsNullOrEmpty(ad) )
            {
                MessageBox.Show("Ad Soyad boş olamaz");
                return;
            }

            Musteri m = new Musteri
            {
                AdSoyad = ad,
                Email = epostaTxtbox.Text.Trim(),
                Telefon = telefonTxtbox.Text.Trim()
                // Adres DB'de yok → bilerek eklenmedi
            };

            musteriService.Ekle(m);

            Listele();
            Temizle();
        }

        private void musteriDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            epostaTxtbox.Text = musteriDgv.Rows[e.RowIndex].Cells["Email"].Value.ToString();
            telefonTxtbox.Text = musteriDgv.Rows[e.RowIndex].Cells["Telefon"].Value.ToString();
            adTxtbox.Text = musteriDgv.Rows[e.RowIndex].Cells["AdSoyad"].Value.ToString();
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {

        }

        private void silButton_Click(object sender, EventArgs e)
        {

        }
    }
}
