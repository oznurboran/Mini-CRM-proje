using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRMProjeyeni.DAL;
using CRMProjeyeni.Domain;

namespace CRMProjeyeni.Service
{
    public class TalepService
    {
        private TalepDAL dal = new TalepDAL();

        public void TalepBeklemeyeAl(int talepId)
        {
            dal.TalepDurumGuncelle(talepId, "Beklemede");
        }

        public void TalepOlustur(Talep t)
        {
            t.Durum = "Acik";
            dal.TalepEkle(t);
        }

        public void TalepTamamla(int talepId)
        {
            dal.TalepDurumGuncelle(talepId, "Tamamlandi");
        }

        public List<Talep> Listele()
        {
            return dal.TumTalepler();
        }
        public void DurumGuncelle(int talepId, string durum)
        {
            dal.DurumGuncelle(talepId, durum);
        }
        public List<RaporDTO> HizmetYogunluguGetir()
        {
            return dal.HizmetYogunluguRaporu();
        }
        public double OrtalamaCozumSuresiGetir()
        {
            return dal.OrtalamaCozumSuresiGun();
        }
       
        public List<Tuple<string, int>> MusteriBazliTalepRaporu()
        {
            return dal.MusteriBazliTalepSayisi();
        }
       
        
            private readonly TalepDAL talepDal;

            public TalepService()
            {
                talepDal = new TalepDAL();
            }

            public List<TalepListeDTO> TalepListele()
            {
                return talepDal.TalepListele();
            }
        public List<(string, double)> MusteriMemnuniyetRaporuGetir()
        {
            return talepDal.MusteriMemnuniyetRaporuGetir();
        }
        public List<(string, int)> PersonelPerformansGetir()
        {
            return talepDal.PersonelPerformansGetir();
        }






    }
}
