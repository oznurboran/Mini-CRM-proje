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
    public class KullaniciDAL
    {
            public Kullanici GirisYap(string kAdi, string sifre)
            {
            using (var con = DbBaglanti.Getir())
            {
                con.Open();
                string sql = "SELECT * FROM Kullanicilar WHERE KullaniciAdi=@ka AND Sifre=@s";

                using (var cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@ka", kAdi);
                    cmd.Parameters.AddWithValue("@s", sifre);

                    using (var dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            return new Kullanici
                            {
                                KullaniciId = Convert.ToInt32(dr["KullaniciId"]),
                                KullaniciAdi = dr["KullaniciAdi"].ToString(),
                                Sifre = dr["Sifre"].ToString(),
                                Rol = dr["Rol"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }
        public void KullaniciEkle(string kullaniciAdi, string sifre, string rol)
        {
            using (MySqlConnection conn = DbBaglanti.Getir())
            {
                string sql = @"INSERT INTO Kullanicilar (KullaniciAdi, Sifre, Rol)
                       VALUES (@kadi, @sifre, @rol)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@kadi", kullaniciAdi);
                cmd.Parameters.AddWithValue("@sifre", sifre);
                cmd.Parameters.AddWithValue("@rol", rol);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
        public bool SifreGuncelle(string kullaniciAdi, string yeniSifre)
        {
            using (MySqlConnection conn = DbBaglanti.Getir())
            {
                string sql = @"UPDATE Kullanicilar 
                       SET Sifre = @sifre 
                       WHERE KullaniciAdi = @kadi";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@sifre", yeniSifre);
                cmd.Parameters.AddWithValue("@kadi", kullaniciAdi);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }


    }
}
