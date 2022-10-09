using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ogrenci_Bilgi_Sistemi__OBS_.islemler;

namespace Ogrenci_Bilgi_Sistemi__OBS_.ogrenci
{
    public partial class ogrenciGiris : Form
    {
        public ogrenciGiris()
        {
            InitializeComponent();
        }
        public static string gidenbilgi = "";
        private void button2_Click(object sender, EventArgs e)
        {
            kullaniciGirisEkrani goAnaGiris = new kullaniciGirisEkrani();
            goAnaGiris.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (girisIslemi.ogrenciGirisi(textBox1.Text, textBox2.Text))
            {
                ogrenciMenu goOgrenciMenu = new ogrenciMenu();
                MessageBox.Show("Giriş Başarılı! Öğrenci Bilgi Sistemine Yönlendiriliyorsunuz...", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
              
                this.Hide();
                goOgrenciMenu.ShowDialog();           // önceki sayfayı gizler ama kapatmaz

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
