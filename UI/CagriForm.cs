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
    public partial class CagriForm: Form
    {
        MusteriService musteriService = new MusteriService();
        HizmetService hizmetService = new HizmetService();
        PersonelService personelService = new PersonelService();
        TalepService talepService = new TalepService();

        public CagriForm()
        {
            InitializeComponent();
        }

        private void CagriForm_Load(object sender, EventArgs e)
        {
            MusteriDoldur();
            HizmetDoldur();
            PersonelDoldur();
        }
        private void MusteriDoldur()
        {
            musteriCmbbox.DisplayMember = "AdSoyad";
            musteriCmbbox.ValueMember = "MusteriId";
            musteriCmbbox.DataSource = musteriService.Listele();
            musteriCmbbox.SelectedIndex = -1;
        }
        private void HizmetDoldur()
        {
            hizmetCmbbox.DisplayMember = "HizmetAdi";
            hizmetCmbbox.ValueMember = "HizmetId";
            hizmetCmbbox.DataSource = hizmetService.Listele();
            hizmetCmbbox.SelectedIndex = -1;
        }
        private void PersonelDoldur()
        {
            personelCombobox.DisplayMember = "AdSoyad";
            personelCombobox.ValueMember = "PersonelId";
            personelCombobox.DataSource = personelService.Listele();
            personelCombobox.SelectedIndex = -1;
        }

        private void talepolusturButton_Click(object sender, EventArgs e)
        {
            if (musteriCmbbox.SelectedIndex == -1 ||
          hizmetCmbbox.SelectedIndex == -1 ||
          personelCombobox.SelectedIndex == -1)
            {
                MessageBox.Show("Müşteri, Hizmet ve Personel seçiniz.");
                return;
            }

            if (string.IsNullOrWhiteSpace(aciklamaTxtbox.Text))
            {
                MessageBox.Show("Açıklama boş olamaz.");
                return;
            }

            Talep t = new Talep
            {
                MusteriId = (int)musteriCmbbox.SelectedValue,
                HizmetId = (int)hizmetCmbbox.SelectedValue,
                PersonelId = (int)personelCombobox.SelectedValue,
                Aciklama = aciklamaTxtbox.Text.Trim()
            };

            talepService.TalepOlustur(t);

            MessageBox.Show("Talep oluşturuldu.");
            aciklamaTxtbox.Clear();
        }
    }
}
