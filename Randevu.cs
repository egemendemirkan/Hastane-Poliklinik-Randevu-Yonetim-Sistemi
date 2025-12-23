using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlar
{
    public class Randevu
    {
        public Doktor RandevuDoktoru { get; set; }
        public Hasta RandevuHastasi { get; set; }
        public DateTime RandevuTarihi { get; set; }
        public string Teshis { get; set; }
        public string Tedavi { get; set; }

    }
}
