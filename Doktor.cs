using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlar
{
    public class Doktor : Personel
    {
        public string Brans { get; set; }
        public Doktor()
        {
            this.Rol = "Doktor";
        }
    }
}
