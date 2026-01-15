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
    public partial class DestekForm: Form
    {

        TalepService talepService = new TalepService();
        public DestekForm()
        {
            InitializeComponent();
        }

        private void DestekForm_Load(object sender, EventArgs e)
        {

            Listele();
            DurumDoldur();
        }
        private void Listele()
        {
            talepdgv.DataSource = talepService.Listele();
        }
        private void DurumDoldur()
        {
            durumCmbbox.Items.Clear();
            durumCmbbox.Items.Add("Beklemede");
            durumCmbbox.Items.Add("İşlemde");
            durumCmbbox.Items.Add("Tamamlandı");
            durumCmbbox.SelectedIndex = 0;
        }

        private void talepdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            durumCmbbox.Text = talepdgv.Rows[e.RowIndex]
                .Cells["Durum"].Value.ToString();

            if (talepdgv.CurrentRow == null) return;

            string durum = talepdgv.CurrentRow.Cells["Durum"].Value.ToString();

            bool tamamlandi = durum == "Tamamlandı";

            memnuniyetCmbbox.Enabled = tamamlandi;
            memnuniyetkaydetButton.Enabled = tamamlandi;
        }

        private void guncelleButton_Click(object sender, EventArgs e)
        {
            if (talepdgv.CurrentRow == null)
            {
                MessageBox.Show("Talep seçiniz.");
                return;
            }

            int talepId = Convert.ToInt32(
                talepdgv.CurrentRow.Cells["TalepId"].Value
            );

            string durum = durumCmbbox.Text;

            talepService.DurumGuncelle(talepId, durum);

            MessageBox.Show("Talep durumu güncellendi.");
            Listele();
        }

        private void memnuniyetkaydetButton_Click(object sender, EventArgs e)
        {
            if (memnuniyetCmbbox.SelectedItem == null)
            {
                MessageBox.Show("Memnuniyet puanı seçiniz");
                return;
            }

            int puan = Convert.ToInt32(memnuniyetCmbbox.SelectedItem);
            int talepId = Convert.ToInt32(
                talepdgv.CurrentRow.Cells["TalepId"].Value
            );

           

            MessageBox.Show("Memnuniyet kaydedildi");

            TalepleriYukle(); // grid yenile
        }
        private void TalepleriYukle()
        {
            talepdgv.DataSource = talepService.TalepListele();
        }

    }
}
