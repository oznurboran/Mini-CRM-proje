using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMProjeyeni.DAL;
using CRMProjeyeni.Domain;

namespace CRMProjeyeni.Service
{
    public class MusteriService
    {

        private MusteriDAL dal = new MusteriDAL();

        public List<Musteri> Listele()
        {
            return dal.Musteriler();
        }

        public void Ekle(Musteri m)
        {
            if (string.IsNullOrWhiteSpace(m.AdSoyad))
                return;

            dal.MusteriEkle(m);
        }

        public void Guncelle(Musteri m)
        {
            if (m.MusteriId <= 0)
                return;

            dal.MusteriGuncelle(m);
        }

        public void Sil(int musteriId)
        {
            if (musteriId <= 0)
                return;

            dal.MusteriSil(musteriId);
        }
    }
}
