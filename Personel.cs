namespace classlar
{
        public abstract class Personel: IRandevu
        {
            private int id;
            private string adSoyad;
            private string kullaniciAdi;
            private string sifre;

            public int Id { get { return id; }   set { id = value; }}
            public string AdSoyad { get { return adSoyad; } set { adSoyad = value; } }
            public string KullaniciAdi { get { return kullaniciAdi; } set { kullaniciAdi = value; } }
            public string Sifre { get { return sifre; } set { sifre = value; } }

            public string Rol { get; set; }

            public virtual string RandevuOlustur() {
                return "Randevu başarıyla oluşturuldu."; 
            }
            public virtual string RandevuSil() { 
                return "Randevu silindi."; 
            }
        }
    }
