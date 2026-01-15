using CRMProjeyeni.DAL;
using CRMProjeyeni.Domain;
using CRMProjeyeni.Service;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace CRMProjeyeni.UI
{
    public partial class RaporForm : Form
    {
        TalepService talepService = new TalepService();
        public RaporForm()
        {
            InitializeComponent();
        }

        private void ChartHazirla()
        {
            raporChart.Series.Clear();
            raporChart.ChartAreas.Clear();

            ChartArea alan = new ChartArea();
            alan.AxisX.Interval = 1;
            alan.AxisX.MajorGrid.Enabled = false;
            alan.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;

            raporChart.ChartAreas.Add(alan);
        }
        private void TestGrafik()
        {
            ChartHazirla();

            Series seri = new Series();
            seri.ChartType = SeriesChartType.Column;
            seri.Name = "Test";

            seri.Points.AddXY("A", 5);
            seri.Points.AddXY("B", 8);
            seri.Points.AddXY("C", 3);

            raporChart.Series.Add(seri);
        }
        private void HizmetYogunluguTablo()
        {
            raporDgv.DataSource = null;
            raporDgv.DataSource = talepService.HizmetYogunluguGetir();
        }
        private void HizmetYogunluguGrafik()
        {
            ChartHazirla();

            Series seri = new Series();
            seri.Name = "Hizmet Yoğunluğu";
            seri.ChartType = SeriesChartType.Column;
            seri.IsValueShownAsLabel = true;

            List<RaporDTO> liste = talepService.HizmetYogunluguGetir();

            foreach (RaporDTO item in liste)
            {
                seri.Points.AddXY(item.Ad, item.Sayi);
            }

            raporChart.Series.Add(seri);
        }


        private void RaporForm_Load(object sender, EventArgs e)
        {

        }

        private void raporgetirButton_Click(object sender, EventArgs e)
        {


            if (raporCmbbox.SelectedItem == null) return;

            string secim = raporCmbbox.SelectedItem.ToString();

            // HER RAPOR ÖNCESİ TEK SEFER TEMİZLE
            raporChart.Series.Clear();
            raporChart.ChartAreas.Clear();
            ozetLabel.Visible = false;
            raporDgv.DataSource = null;

            // Chart alanını hazırla
            ChartArea alan = new ChartArea();
            alan.AxisX.Interval = 1;
            raporChart.ChartAreas.Add(alan);

            // 1️⃣ Talep Türüne Göre Hizmet Yoğunluğu (GRAFİK + TABLO)
            if (secim == "Talep Türüne Göre Hizmet Yoğunluğu")
            {
                var data = talepService.HizmetYogunluguGetir();
                raporDgv.DataSource = data;

                var seri = raporChart.Series.Add("Hizmet Yoğunluğu");
                seri.ChartType = SeriesChartType.Column;
                seri.IsValueShownAsLabel = true;

                foreach (var item in data)
                {
                    seri.Points.AddXY(item.Ad, item.Sayi);
                }
            }

            // 2️⃣ Ortalama Çözüm Süresi (SADECE YAZI)
            else if (secim == "Ortalama Çözüm Süresi")
            {
                double gun = talepService.OrtalamaCozumSuresiGetir();

                raporDgv.DataSource = new List<object>
    {
        new { Aciklama = "Ortalama Çözüm Süresi (Gün)", Deger = gun }
    };

                ozetLabel.Text = "Ortalama çözüm süresi: " + gun.ToString("0.0") + " gün";
                ozetLabel.Visible = true;
            }

            // 3️⃣ Personel Performans Raporu (GRAFİK)
            else if (secim == "Personel Performans Raporu")
            {
                var data = talepService.PersonelPerformansGetir();

                // ✅ TABLO
                raporDgv.DataSource = data
                    .Select(x => new
                    {
                        Personel = x.Item1,
                        CozulenTalep = x.Item2
                    }).ToList();

                int toplamTalep = data.Sum(x => x.Item2);

                var seri = raporChart.Series.Add("Personel Performansı");
                seri.ChartType = SeriesChartType.Column;
                seri.IsValueShownAsLabel = true;

                raporChart.ChartAreas[0].AxisX.Interval = 1;
                raporChart.ChartAreas[0].AxisX.LabelStyle.Angle = -45;

                string enIyiPersonel = "";
                int maxTalep = 0;

                foreach (var item in data)
                {
                    seri.Points.AddXY(item.Item1, item.Item2);

                    if (item.Item2 > maxTalep)
                    {
                        maxTalep = item.Item2;
                        enIyiPersonel = item.Item1;
                    }
                }

                ozetLabel.Text =
                    $"🏆 En iyi personel: {enIyiPersonel}\n" +
                    $"📊 Toplam çözülen talep: {toplamTalep}";
                ozetLabel.Visible = true;
            }


            // 4️⃣ Müşteri Bazlı Talep Raporu (GRAFİK)
            else if (secim == "Müşteri Bazlı Talep Raporu")
            {
                var data = talepService.MusteriBazliTalepRaporu();

                // ✅ TABLO
                raporDgv.DataSource = data
                    .Select(x => new
                    {
                        Musteri = x.Item1,
                        TalepSayisi = x.Item2
                    }).ToList();

                var seri = raporChart.Series.Add("Müşteri Bazlı Talepler");
                seri.ChartType = SeriesChartType.Column;
                seri.IsValueShownAsLabel = true;

                foreach (var item in data)
                {
                    seri.Points.AddXY(item.Item1, item.Item2);
                }
            }
            // 5️⃣ Müşteri Memnuniyet Raporu (GRAFİK)
            else if (secim == "Müşteri Memnuniyet Raporu")
            {
                var data = talepService.MusteriMemnuniyetRaporuGetir();

                // ✅ TABLO
                raporDgv.DataSource = data
                    .Select(x => new
                    {
                        Musteri = x.Item1,
                        MemnuniyetPuani = x.Item2
                    }).ToList();

                var seri = raporChart.Series.Add("Müşteri Memnuniyeti");
                seri.ChartType = SeriesChartType.Column;
                seri.IsValueShownAsLabel = true;

                foreach (var item in data)
                {
                    seri.Points.AddXY(item.Item1, item.Item2);
                }
            }
        }
        public List<(string, int)> PersonelPerformansGetir()
        {
            var liste = new List<(string, int)>();

            using (MySqlConnection conn = DbBaglanti.Getir())
            {
                string sql = @"
            SELECT 
                p.AdSoyad AS Personel,
                COUNT(t.TalepId) AS CozulenTalep
            FROM Talepler t
            INNER JOIN Personeller p ON p.PersonelId = t.PersonelId
            WHERE t.Durum = 'Tamamlandi'
            GROUP BY p.AdSoyad";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        liste.Add((
                            dr.GetString("Personel"),
                            dr.GetInt32("CozulenTalep")
                        ));
                    }
                }
            }

            return liste;
        }

        private void raporDgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}

      



    

