using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using classlar;

namespace poliklinik_randevu_sistemi
{
    public partial class giriş2 : Form
    {
        public giriş2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void giriş2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            classlar.Personel bulunanKullanici = null;

            foreach (var p in classlar.VeriKaynagi.Personeller)
            {
                if (p.KullaniciAdi == textBox1.Text && p.Sifre == textBox2.Text)
                {
                    bulunanKullanici = p;
                    break;
                }
            }

            if (bulunanKullanici != null)
            {
                MessageBox.Show(bulunanKullanici.AdSoyad + " olarak giriş yapıldı.");
                this.Hide();

                if (bulunanKullanici.Rol == "Yonetici")
                {
                    YÖNETİCİ yoneticiForm = new YÖNETİCİ();
                    yoneticiForm.Show();
                }
                else if (bulunanKullanici.Rol == "Doktor")
                {
                    DOKTOR doktorForm = new DOKTOR();
                    doktorForm.Show();
                }
                else if (bulunanKullanici.Rol == "Sekreter")
                {
                    Sekreter sekreterForm = new Sekreter();
                    sekreterForm.Show();
                }
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!");
            }
        }
    }
}
