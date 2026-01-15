using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMProjeyeni.Domain;
using CRMProjeyeni.DAL;
using MySql.Data.MySqlClient;

namespace CRMProjeyeni.DAL
{
    public class PersonelDAL
    {
        public List<Personel> TumPersoneller()
        {
            var liste = new List<Personel>();

            using (var con = DbBaglanti.Getir())
            {
                con.Open();
                string sql = "SELECT * FROM Personeller";

                using (var cmd = new MySqlCommand(sql, con))
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        liste.Add(new Personel
                        {
                            PersonelId = Convert.ToInt32(dr["PersonelId"]),
                            AdSoyad = dr["AdSoyad"].ToString(),
                            Uzmanlik = dr["Uzmanlik"] == DBNull.Value ? null : dr["Uzmanlik"].ToString()
                        });
                    }
                }
            }
            return liste;
        }

        public void PersonelEkle(Personel p)
        {
            using (var con = DbBaglanti.Getir())
            {
                con.Open();
                string sql = "INSERT INTO Personeller (AdSoyad, Uzmanlik) VALUES (@ad, @uz)";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ad", p.AdSoyad);
                    cmd.Parameters.AddWithValue("@uz", p.Uzmanlik);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void PersonelGuncelle(Personel p)
        {
            using (var con = DbBaglanti.Getir())
            {
                con.Open();
                string sql = "UPDATE Personeller SET AdSoyad=@ad, Uzmanlik=@uz WHERE PersonelId=@id";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ad", p.AdSoyad);
                    cmd.Parameters.AddWithValue("@uz", p.Uzmanlik);
                    cmd.Parameters.AddWithValue("@id", p.PersonelId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void PersonelSil(int personelId)
        {
            using (var con = DbBaglanti.Getir())
            {
                con.Open();
                string sql = "DELETE FROM Personeller WHERE PersonelId=@id";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", personelId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
