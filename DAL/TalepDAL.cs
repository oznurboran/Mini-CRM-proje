using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMProjeyeni.Domain;
using MySql.Data.MySqlClient;


namespace CRMProjeyeni.DAL
{
    public class TalepDAL : DbBaglanti
    {
        public void TalepEkle(Talep t)
        {
            using (var con = DbBaglanti.Getir())
            {
                con.Open();
                string sql = @"INSERT INTO Talepler
        (MusteriId, PersonelId, HizmetId, Durum, Aciklama)
        VALUES (@m,@p,@h,@d,@a)";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@m", t.MusteriId);
                    cmd.Parameters.AddWithValue("@p", t.PersonelId);
                    cmd.Parameters.AddWithValue("@h", t.HizmetId);
                    cmd.Parameters.AddWithValue("@d", t.Durum);
                    cmd.Parameters.AddWithValue("@a", t.Aciklama);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void TalepDurumGuncelle(int talepId, string durum)
        {
            using (var con = DbBaglanti.Getir())
            {
                con.Open();
                string sql = @"UPDATE Talepler
                       SET Durum=@d,
                           TamamlanmaTarihi = IF(@d='Tamamlandi', NOW(), NULL)
                       WHERE TalepId=@id";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@d", durum);
                    cmd.Parameters.AddWithValue("@id", talepId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<Talep> TumTalepler()
        {
            var liste = new List<Talep>();

            using (var con = DbBaglanti.Getir())
            {
                con.Open();
                string sql = "SELECT * FROM Talepler";

                using (var cmd = new MySqlCommand(sql, con))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        liste.Add(new Talep
                        {
                            TalepId = Convert.ToInt32(dr["TalepId"]),
                            MusteriId = Convert.ToInt32(dr["MusteriId"]),
                            PersonelId = Convert.ToInt32(dr["PersonelId"]),
                            HizmetId = Convert.ToInt32(dr["HizmetId"]),
                            Durum = dr["Durum"].ToString(),
                            OlusturmaTarihi = Convert.ToDateTime(dr["OlusturmaTarihi"]),
                            TamamlanmaTarihi = dr["TamamlanmaTarihi"] == DBNull.Value ? null :
                                               (DateTime?)Convert.ToDateTime(dr["TamamlanmaTarihi"]),
                            Aciklama = dr["Aciklama"].ToString()
                        });
                    }
                }
            }
            return liste;
        }
        public void DurumGuncelle(int talepId, string durum)
        {
            using (MySqlConnection con = DbBaglanti.Getir())
            {
                con.Open();

                string sql = @"UPDATE Talepler 
                   SET Durum=@durum 
                   WHERE TalepId=@id";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@durum", durum);
                cmd.Parameters.AddWithValue("@id", talepId);

                cmd.ExecuteNonQuery();
            }
        }
        public List<RaporDTO> HizmetYogunluguRaporu()
        {
            List<RaporDTO> liste = new List<RaporDTO>();

            MySqlConnection con = DbBaglanti.Getir();
            con.Open();

            string sql = @"
        SELECT h.HizmetAdi, COUNT(*) AS TalepSayisi
        FROM Talepler t
        JOIN Hizmetler h ON t.HizmetId = h.HizmetId
        GROUP BY h.HizmetAdi";

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                RaporDTO dto = new RaporDTO();
                dto.Ad = dr["HizmetAdi"].ToString();
                dto.Sayi = Convert.ToInt32(dr["TalepSayisi"]);
                liste.Add(dto);
            }

            dr.Close();
            con.Close();

            return liste;
        }
        public double OrtalamaCozumSuresiGun()
        {
            double ortalama = 0;

            var con = DbBaglanti.Getir();
            con.Open();

            string sql =
                "SELECT AVG(DATEDIFF(TamamlanmaTarihi, OlusturmaTarihi)) " +
                "FROM Talepler WHERE TamamlanmaTarihi IS NOT NULL";

            var cmd = new MySqlCommand(sql, con);
            var sonuc = cmd.ExecuteScalar();

            if (sonuc != DBNull.Value)
                ortalama = Convert.ToDouble(sonuc);

            con.Close();
            return ortalama;
        }
        public List<Tuple<string, int>> PersonelPerformans()
        {
            var liste = new List<Tuple<string, int>>();

            var con = DbBaglanti.Getir();
            con.Open();

            string sql =
                "SELECT p.AdSoyad, COUNT(t.TalepId) " +
                "FROM Talepler t " +
                "JOIN Personeller p ON p.PersonelId = t.PersonelId " +
                "WHERE t.Durum = 'Tamamlandı' " +
                "GROUP BY p.AdSoyad";

            var cmd = new MySqlCommand(sql, con);
            var dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                string ad = dr.GetString(0);
                int sayi = dr.GetInt32(1);
                liste.Add(new Tuple<string, int>(ad, sayi));
            }

            con.Close();
            return liste;
        }

        public List<Tuple<string, int>> MusteriBazliTalepSayisi()
        {
            List<Tuple<string, int>> liste = new List<Tuple<string, int>>();

            using (MySqlConnection con = DbBaglanti.Getir())
            {
                con.Open();

                string sql = @"
        SELECT m.AdSoyad AS Musteri,
               COUNT(t.TalepId) AS TalepSayisi
        FROM Talepler t
        INNER JOIN Musteriler m ON t.MusteriId = m.MusteriId
        GROUP BY m.MusteriId, m.AdSoyad";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    liste.Add(new Tuple<string, int>(
                        dr["Musteri"].ToString(),
                        Convert.ToInt32(dr["TalepSayisi"])
                    ));
                }
            }

            return liste;
        }
        public List<TalepListeDTO> TalepListele()
        {
            List<TalepListeDTO> liste = new List<TalepListeDTO>();

            using (MySqlConnection conn = DbBaglanti.Getir())
            {
                string sql = @"
            SELECT 
                t.TalepId,
                m.AdSoyad AS MusteriAdi,
                h.HizmetAdi,
                t.Aciklama,
                t.OlusturmaTarihi AS TalepTarihi,
                t.Durum
            FROM Talepler t
            INNER JOIN Musteriler m ON m.MusteriId = t.MusteriId
            INNER JOIN Hizmetler h ON h.HizmetId = t.HizmetId
            ORDER BY t.OlusturmaTarihi DESC";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        liste.Add(new TalepListeDTO
                        {
                            TalepId = dr.GetInt32("TalepId"),
                            MusteriAdi = dr.GetString("MusteriAdi"),
                            HizmetAdi = dr.GetString("HizmetAdi"),
                            Aciklama = dr.GetString("Aciklama"),
                            TalepTarihi = dr.GetDateTime("TalepTarihi"),
                            Durum = dr.GetString("Durum")
                        });
                    }
                }
            }

            return liste;



        }
        public List<(string, double)> MusteriMemnuniyetRaporuGetir()
        {
            var liste = new List<(string, double)>();

            using (MySqlConnection conn = DbBaglanti.Getir())
            {
                string sql = @"
    SELECT 
        p.AdSoyad AS Personel,
        AVG(t.MemnuniyetPuan) AS OrtalamaPuan
    FROM Talepler t
    INNER JOIN Personeller p ON p.PersonelId = t.PersonelId
    WHERE t.MemnuniyetPuan IS NOT NULL
    GROUP BY p.AdSoyad";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                conn.Open();

                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        liste.Add((
                            dr.GetString("Personel"),
                            Convert.ToDouble(dr["OrtalamaPuan"])
                        ));
                    }
                }
            }

            return liste;
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



    }
}
