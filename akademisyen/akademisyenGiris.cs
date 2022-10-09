using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ogrenci_Bilgi_Sistemi__OBS_;

namespace Ogrenci_Bilgi_Sistemi__OBS_.akademisyen
{
    public partial class akademisyenGiris : Form
    {
        public akademisyenGiris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kullaniciGirisEkrani goAnaGiris = new kullaniciGirisEkrani();
            goAnaGiris.Show();
            this.Hide();
        }
    }
}
