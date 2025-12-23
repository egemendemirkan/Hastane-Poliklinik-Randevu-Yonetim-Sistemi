using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classlar
{
    public static class VeriKaynagi
    {
        public static List<Personel> Personeller = new List<Personel>();
        public static List<Hasta> Hastalar = new List<Hasta>();
        public static List<Randevu> Randevular = new List<Randevu>();

        static VeriKaynagi()
        {
            Personeller.Add(new Yonetici { Id = 1, AdSoyad = "Admin User", KullaniciAdi = "admin", Sifre = "admin123" });
            Personeller.Add(new Doktor { Id =2, AdSoyad ="Dr. Egemen Demirkan", KullaniciAdi="edemirkan", Sifre ="egemen12", Brans="Kardiyoloji" });
            Personeller.Add(new Sekreter { Id =3, AdSoyad ="Nehir Leyla Kaymacı", KullaniciAdi="nehirleyla", Sifre ="nehir12" });

        }
    }
}
