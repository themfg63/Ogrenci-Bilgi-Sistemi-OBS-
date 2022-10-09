using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;        // sql bağlanti ve islem kütüphanesi

namespace Ogrenci_Bilgi_Sistemi__OBS_.islemler
{
    class girisIslemi
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static DataSet ds;

        public static string sqlCon = @"Data Source=DESKTOP-K2C3H0A;Initial Catalog=OgrenciBilgiSistemi;Integrated Security=True";

        // ÖĞRENCİ GİRİŞİ
        public static bool ogrenciGirisi(string kullaniciAdi, string sifre)
        {
            string sorgu = "select * from tbl_ogrBilgileri where ogrNo=@user and ogrSifre=@pass"; //parametreli sql sorgusu

            con = new SqlConnection(sqlCon);
            cmd = new SqlCommand(sorgu, con);
            cmd.Parameters.AddWithValue("@user", kullaniciAdi);
            cmd.Parameters.AddWithValue("@pass",sifre);

            con.Open();
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }
    }
}
