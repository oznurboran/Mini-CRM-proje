using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRMProjeyeni.Domain
{
    public class Talep
    {
        public int TalepId { get; set; }
        public int MusteriId { get; set; }
        public int PersonelId { get; set; }
        public int HizmetId { get; set; }
        public string Durum { get; set; } // enum('Acik','Beklemede','Tamamlandi')
        public DateTime OlusturmaTarihi { get; set; }
        public DateTime? TamamlanmaTarihi { get; set; }
        public string Aciklama { get; set; }
        public int? MemnuniyetPuan { get; set; }

    }
}
