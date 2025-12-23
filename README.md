# Hastane Poliklinik Randevu Yönetim Sistemi

Bu proje, **Nesne Yönelimli Programlama (OOP)** dersi kapsamında C# dili kullanılarak geliştirilmiş bir yönetim simülasyonudur. Bir sağlık kliniğindeki günlük operasyonları (hasta kaydı, randevu yönetimi ve muayene işlemleri) dijitalleştirmeyi amaçlar.

## 🚀 Özellikler ve Kullanıcı Rolleri

Sistemde üç farklı yetki seviyesi bulunmaktadır:

- **Yönetici Paneli:** Yeni personel (Doktor, Sekreter) ekleme, listeleme ve silme işlemlerini yapar.
- **Sekreter Paneli:** Yeni hasta kaydı oluşturur ve uygun doktorlara randevu tanımlar.
- **Doktor Paneli:** Kendisine atanan randevuları görür ve hastalar için teşhis/tedavi girişi yapar.

## 🛠 Kullanılan Teknolojiler ve OOP Prensipleri

Bu projede OOP'nin temel direkleri aktif olarak kullanılmıştır:

- **Kalıtım (Inheritance):** `Personel` ana sınıfından `Doktor`, `Sekreter` ve `Yonetici` sınıfları türetilmiştir.
- **Arayüzler (Interfaces):** Randevu işlemleri için `IRandevu` arayüzü kullanılarak metod standartları belirlenmiştir.
- **Kapsülleme (Encapsulation):** Veri güvenliği için `Property` yapıları kullanılmıştır.
- **Polimorfizm (Çok Biçimlilik):** Farklı kullanıcı tiplerinin ortak metodları farklı şekilde icra etmesi sağlanmıştır.
- **Statik Veri Yönetimi:** Veriler, çalışma zamanında `VeriKaynagi` sınıfındaki statik listelerde tutulmaktadır.
