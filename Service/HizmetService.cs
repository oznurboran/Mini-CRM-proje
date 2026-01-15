using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMProjeyeni.DAL;
using CRMProjeyeni.Domain;

namespace CRMProjeyeni.Service
{
    class HizmetService
    {

        private HizmetDAL dal = new HizmetDAL();

        public List<Hizmet> Listele()
        {
            return dal.TumHizmetler();
        }

        public void Ekle(Hizmet h)
        {
            if (string.IsNullOrWhiteSpace(h.HizmetAdi))
                return;

            dal.HizmetEkle(h);
        }

        public void Guncelle(Hizmet h)
        {
            if (h.HizmetId <= 0)
                return;

            dal.HizmetGuncelle(h);
        }

        public void Sil(int hizmetId)
        {
            if (hizmetId <= 0)
                return;

            dal.HizmetSil(hizmetId);
        }
    }
}
