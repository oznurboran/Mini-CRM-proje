using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRMProjeyeni.Domain;
using CRMProjeyeni.Service;

namespace CRMProjeyeni.UI
{
    public partial class HizmetForm: Form
    {
        HizmetService hizmetService = new HizmetService();
        public HizmetForm()
        {
            InitializeComponent();
        }

        private void HizmetForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void Listele()
        {
            hizmetformdgv.DataSource = null;
            hizmetformdgv.DataSource = hizmetService.Listele();
        }

        private void kaydetButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(hizmetadiTxtbox.Text))
            {
                MessageBox.Show("Hizmet adı boş olamaz");
                return;
            }

            if (!decimal.TryParse(ucretTxtbox.Text, out decimal ucret))
            {
                MessageBox.Show("Ücret geçerli bir sayı olmalı");
                return;
            }

            Hizmet h = new Hizmet
            {
                HizmetAdi = hizmetadiTxtbox.Text.Trim(),
                Aciklama = aciklamaTxtbox.Text.Trim(),
                Ucret = ucret
            };

            hizmetService.Ekle(h);
            Listele();
            Temizle();
        }

        private void silButton_Click(object sender, EventArgs e)
        {
            if (hizmetformdgv.CurrentRow == null)
                return;

            int hizmetId = Convert.ToInt32(
                hizmetformdgv.CurrentRow.Cells["HizmetId"].Value
            );

            hizmetService.Sil(hizmetId);
            Listele();
        }
        private void Temizle()
        {
            hizmetadiTxtbox.Clear();
            aciklamaTxtbox.Clear();
            ucretTxtbox.Clear();
        }

        private void hizmetformdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            hizmetadiTxtbox.Text = hizmetformdgv.Rows[e.RowIndex].Cells["HizmetAdi"].Value.ToString();
            aciklamaTxtbox.Text = hizmetformdgv.Rows[e.RowIndex].Cells["Aciklama"].Value.ToString();
            ucretTxtbox.Text = hizmetformdgv.Rows[e.RowIndex].Cells["Ucret"].Value.ToString();
        }
    }
}
