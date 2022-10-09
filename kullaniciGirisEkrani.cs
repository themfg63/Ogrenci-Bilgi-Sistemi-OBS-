using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ogrenci_Bilgi_Sistemi__OBS_.akademisyen;
using Ogrenci_Bilgi_Sistemi__OBS_.islemler;
using Ogrenci_Bilgi_Sistemi__OBS_.ogrenci;


namespace Ogrenci_Bilgi_Sistemi__OBS_
{
    public partial class kullaniciGirisEkrani : Form
    {
        public kullaniciGirisEkrani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // formlar arası geçiş
            ogrenciGiris goOgrenciGiris = new ogrenciGiris();
            goOgrenciGiris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // formlar arası geçiş
            akademisyenGiris goAkademisyenGiris = new akademisyenGiris(); // geçmek istediğimiz formu nesne haline getiriyoruz
            goAkademisyenGiris.Show();                                    // formu göster komutu
            this.Hide();                                                  // şu anki formu arka planda çalışmaya gönder komutu
        }
    }
}
