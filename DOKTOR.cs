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
    public partial class DOKTOR : Form
    {
        public DOKTOR()
        {
            InitializeComponent();
        }

        private void RANDEVULAR_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RANDEVULAR.SelectedIndex != -1)
            {
                var seciliRandevu = classlar.VeriKaynagi.Randevular[RANDEVULAR.SelectedIndex];

                textBox1.Text = seciliRandevu.RandevuHastasi.AdSoyad;
                textBox2.Text = seciliRandevu.RandevuHastasi.TCKimlikNo;
                textBox3.Text = seciliRandevu.RandevuHastasi.DogumTarihi.ToShortDateString();
                textBox4.Text = seciliRandevu.Teshis;
                textBox5.Text = seciliRandevu.Tedavi;
            }
        }

        private void DOKTOR_Load(object sender, EventArgs e)
        {
            foreach (var randevu in classlar.VeriKaynagi.Randevular)
            {
                RANDEVULAR.Items.Add($"{randevu.RandevuHastasi.AdSoyad} - {randevu.RandevuTarihi.ToShortTimeString()}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (RANDEVULAR.SelectedIndex != -1)
            {
                var randevu = classlar.VeriKaynagi.Randevular[RANDEVULAR.SelectedIndex];
                randevu.Teshis = textBox4.Text;
                randevu.Tedavi = textBox5.Text;

                MessageBox.Show("Muayene bilgileri kaydedildi.");
            }
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
