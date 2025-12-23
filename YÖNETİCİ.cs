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
    public partial class YÖNETİCİ : Form
    {
        public YÖNETİCİ()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void YÖNETİCİ_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            classlar.Personel yeniPersonel;
            string secilenRol = comboBox1.SelectedItem.ToString();

            if (secilenRol == "Doktor") yeniPersonel = new classlar.Doktor();
            else if (secilenRol == "Sekreter") yeniPersonel = new classlar.Sekreter();
            else yeniPersonel = new classlar.Yonetici();

            yeniPersonel.AdSoyad = textBox1.Text;
            yeniPersonel.KullaniciAdi = textBox2.Text;
            yeniPersonel.Sifre = textBox3.Text;

            classlar.VeriKaynagi.Personeller.Add(yeniPersonel);
            Listele();
        }
        private void Listele()
        {
            kullanıcılar.Items.Clear();
            foreach (var p in classlar.VeriKaynagi.Personeller)
            {
                kullanıcılar.Items.Add($"{p.Rol}: {p.AdSoyad}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (kullanıcılar.SelectedIndex != -1)
            {
                int index = kullanıcılar.SelectedIndex;

                classlar.VeriKaynagi.Personeller.RemoveAt(index);

                kullanıcılar.Items.RemoveAt(index);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            giriş anaGiris = new giriş();

            anaGiris.Show();

            this.Close();
        }
    }
}
