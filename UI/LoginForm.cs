using CRMProjeyeni.Domain;
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
using System.Runtime.InteropServices;


namespace CRMProjeyeni.UI
{
    public partial class LoginForm: Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
(
  int nLeftRect,
  int nTopRect,
  int nRightRect,
  int nBottomRect,
  int nWidthEllipse,
  int nHeightEllipse
);
        private KullaniciService kullaniciService = new KullaniciService();
        public LoginForm()
        {
            InitializeComponent();
        }

      

        private void LoginForm_Load(object sender, EventArgs e)
        {

            panelLogin.Region = Region.FromHrgn(
       CreateRoundRectRgn(0, 0, panelLogin.Width, panelLogin.Height, 25, 25)
   );
        }

     

      

        private void girisButton_Click_1(object sender, EventArgs e)
        {
            string kullaniciAdi = kullaniciadiTxtbox.Text.Trim();
            string sifre = sifreTxtbox.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş olamaz");
                return;
            }

            Kullanici kullanici = kullaniciService.Giris(kullaniciAdi, sifre);

            if (kullanici == null)
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                return;
            }

            // 🔐 ROL KONTROLÜ
            Form acilacakForm = null;

            switch (kullanici.Rol)
            {
                case "Admin":
                    acilacakForm = new AdminForm();
                    break;

                case "Cagri":
                    acilacakForm = new CagriForm();
                    break;

                case "Destek":
                    acilacakForm = new DestekForm();
                    break;

                default:
                    MessageBox.Show("Yetkisiz kullanıcı rolü");
                    return;
            }

            // Login ekranını gizle, yeni formu aç
            this.Hide();

            acilacakForm.Show();

        }

        private void sifreunutButton_Click_1(object sender, EventArgs e)
        {

            var frm = new SifremiUnuttumForm();
            frm.ShowDialog();
        }

        private void yenikullaniciButton_Click_1(object sender, EventArgs e)
        {

            var frm = new YeniKullaniciForm();
            frm.ShowDialog(); // Login açık kalsın
        }
    }

    
}
