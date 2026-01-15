using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMProjeyeni.DAL;
using CRMProjeyeni.Domain;


namespace CRMProjeyeni.Service
{
    public class KullaniciService
    {
 
            private KullaniciDAL dal = new KullaniciDAL();

            public Kullanici Giris(string kAdi, string sifre)
            {
                if (string.IsNullOrEmpty(kAdi) || string.IsNullOrEmpty(sifre))
                    return null;

                return dal.GirisYap(kAdi, sifre);
            }
        public void KullaniciEkle(string kullaniciAdi, string sifre, string rol)
        {
            dal.KullaniciEkle(kullaniciAdi, sifre, rol);
        }

        public bool SifreGuncelle(string kullaniciAdi, string yeniSifre)
        {
            return dal.SifreGuncelle(kullaniciAdi, yeniSifre);
        }

    }
}
