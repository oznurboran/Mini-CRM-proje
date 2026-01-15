using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMProjeyeni.Domain;
using MySql.Data.MySqlClient;


namespace CRMProjeyeni.DAL
{
    public class MusteriDAL
    { 
        public List<Musteri> Musteriler()
        {
            List<Musteri> liste = new List<Musteri>();

            using (var con = DbBaglanti.Getir())
            {
                con.Open();

                string sql = "SELECT * FROM Musteriler";
                using (var cmd = new MySqlCommand(sql, con))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            liste.Add(new Musteri
                            {
                                MusteriId = Convert.ToInt32(dr["MusteriId"]),
                                AdSoyad = dr["AdSoyad"].ToString(),
                                Telefon = dr["Telefon"].ToString(),
                                Email = dr["Email"].ToString()
                            });
                        }
                    }
                }
            }

            return liste;
        }

        

        public void MusteriEkle(Musteri m)
        {
         
        
            using (var con = DbBaglanti.Getir())
            {
                con.Open();

                string sql = "INSERT INTO Musteriler (AdSoyad, Telefon, Email) " +
                             "VALUES (@ad, @tel, @mail)";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ad", m.AdSoyad);
                    cmd.Parameters.AddWithValue("@tel", m.Telefon);
                    cmd.Parameters.AddWithValue("@mail", m.Email);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        

        public void MusteriGuncelle(Musteri m)
        {
            using (var con = DbBaglanti.Getir())
            {
                con.Open();

                string sql = "UPDATE Musteriler SET AdSoyad=@ad, Telefon=@tel, Email=@mail " +
                             "WHERE MusteriId=@id";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ad", m.AdSoyad);
                    cmd.Parameters.AddWithValue("@tel", m.Telefon);
                    cmd.Parameters.AddWithValue("@mail", m.Email);
                    cmd.Parameters.AddWithValue("@id", m.MusteriId);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void MusteriSil(int musteriId)
        {
            using (var con = DbBaglanti.Getir())
            {
                con.Open();

                string sql = "DELETE FROM Musteriler WHERE MusteriId=@id";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@id", musteriId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
