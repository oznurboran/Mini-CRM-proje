using CRMProjeyeni.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRMProjeyeni.UI
{
    public partial class YeniKullaniciForm: Form
    {
        private KullaniciService kullaniciService = new KullaniciService();
        public YeniKullaniciForm()
        {
            InitializeComponent();
        }

       

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kaydetButton_Click_1(object sender, EventArgs e)
        {
            if (kullaniciadiTxtbox.Text == "" || sifreTxtbox.Text == "" || rolCmbbox.SelectedItem == null)
            {
                MessageBox.Show("Tüm alanları doldurun");
                return;
            }

            kullaniciService.KullaniciEkle(
                kullaniciadiTxtbox.Text,
                sifreTxtbox.Text,
                rolCmbbox.SelectedItem.ToString()
            );

            MessageBox.Show("Kullanıcı oluşturuldu");
            this.Close();
        }

        private void rolCmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
