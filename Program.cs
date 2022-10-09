using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ogrenci_Bilgi_Sistemi__OBS_.akademisyen;

namespace Ogrenci_Bilgi_Sistemi__OBS_
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new kullaniciGirisEkrani());
        }
    }
}
