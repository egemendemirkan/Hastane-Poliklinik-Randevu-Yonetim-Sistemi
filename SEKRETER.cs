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
    public partial class Sekreter : Form
    {
        public Sekreter()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Sekreter_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            classlar.Hasta yeniHasta = new classlar.Hasta
            {
                AdSoyad = textBox1.Text + " " + textBox2.Text,
                TCKimlikNo = textBox3.Text,
                Telefon = textBox4.Text,
                DogumTarihi = DateTime.Parse(textBox5.Text)
            };
            classlar.VeriKaynagi.Hastalar.Add(yeniHasta);

            classlar.Randevu yeniRandevu = new classlar.Randevu
            {
                RandevuHastasi = yeniHasta,
                RandevuTarihi = DateTime.Parse(textBox8.Text + " " + textBox9.Text),
            };
            classlar.VeriKaynagi.Randevular.Add(yeniRandevu);

            MessageBox.Show("Hasta ve Randevu Kaydı Yapıldı!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            giriş anaGiris = new giriş();

            anaGiris.Show();

            this.Close();
        }
    }
}
