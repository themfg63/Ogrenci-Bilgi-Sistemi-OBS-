using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;


namespace Ogrenci_Bilgi_Sistemi__OBS_.islemler
{
    class Veritabanibaglantisi
    {
        static SqlConnection con;       //veritabanı ile bağlantıyı gerçekleştirir.
        static SqlDataAdapter da;       //veriyi alma ve kaydetme işlemi yapar.
        static SqlCommand cmd;          //veritabanı sorgularını(ekleme,çıkarma,güncelleme) çalıştırır.
        static DataSet ds;
        

        // hangi cihazdan hangi veritabanına bağlanacağımızı gösteren sql sorgusu
        public static string sqlCon = @"Data Source = DESKTOP - K2C3H0A; Initial Catalog = OgrenciBilgiSistemi; Integrated Security = True";


        // veritabanı bağlantı kontrolü
        public static bool baglantiDurumu()
        {
            using (con = new SqlConnection(sqlCon))
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch (SqlException exp)
                {
                    MessageBox.Show(exp.Message);
                    return false;
                }
            }
        }

        // veritabanından sql sorgusuyla datagridwiev'e veri çekme işlemi
        public static DataGridView gridDoldur(DataGridView grid, string sqlSelectSorgu)
        {
            con = new SqlConnection(sqlCon);                
            da = new SqlDataAdapter(sqlSelectSorgu, con);
            ds = new DataSet();

            con.Open();
            da.Fill(ds, sqlSelectSorgu);
            grid.DataSource = ds.Tables[sqlSelectSorgu];
            con.Close();
            return grid;
        }
    }
}
