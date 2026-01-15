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
    public partial class SifremiUnuttumForm: Form
    {
        private KullaniciService kullaniciService = new KullaniciService();
        public SifremiUnuttumForm()
        {
            InitializeComponent();
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            if (kullaniciadiTxtbox.Text == "" || yenisifreTxtbox.Text == "")
            {
                MessageBox.Show("Alanları doldurun");
                return;
            }

            bool sonuc = kullaniciService.SifreGuncelle(
                kullaniciadiTxtbox.Text,
                yenisifreTxtbox.Text
            );

            if (sonuc)
            {
                MessageBox.Show("Şifre güncellendi");
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı bulunamadı");
            }
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
