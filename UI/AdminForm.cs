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
    public partial class AdminForm: Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            menuPanel.BringToFront(); // menü HER ZAMAN üstte
            icerikPanel.SendToBack();      // içerik arkada ama görünür
        }
        private void FormYukle(Form frm)
        {
             
            frm.TopLevel = false;             // Formu gömülebilir yap
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;

            icerikPanel.Controls.Add(frm);
            frm.BringToFront();
            icerikPanel.Tag = frm;
            frm.Show();
        }


        private void musteriButton_Click(object sender, EventArgs e)
        {
            MusteriForm mf = new MusteriForm();
            FormYukle(mf);
        }

        private void hizmetlerButton_Click(object sender, EventArgs e)
        {
            FormYukle(new HizmetForm());
        }

        private void personellerButton_Click(object sender, EventArgs e)
        {
            FormYukle(new PersonelForm());
        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void taleplerButton_Click(object sender, EventArgs e)
        {
            FormYukle(new TalepForm());
        }

        private void raporlarButton_Click(object sender, EventArgs e)
        {
            FormYukle(new RaporForm());
        }

        private void cikisButton_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is LoginForm)
                {
                    form.Show();
                    break;
                }
            }

            this.Close(); // SADECE bu form kapanır
        }
    }
}
