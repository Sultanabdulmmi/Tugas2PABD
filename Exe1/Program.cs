using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Exe1
{
    class Program
    {

        static void Main(string[] args)
        {
            new Program().InsertData();
        }
        public void InsertData()    
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source=SULTAN-SA11MM5I\\SULTAN;database=Mall;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand("insert into Penyewa ( Code_penyewa, Nama_Penyewa, Usia, Alamat, Telpon) values ('2','Agus','27','Sleman','89529349932')", con);
                SqlCommand sw = new SqlCommand("Sewa (Code_Sewa, Waktu_Penyewaan, Tanggal_Penyewaan, Harga_Sewa) values ('S01'),('1Tahun'),('11/5/2021'),('60'),", con);
                cm.ExecuteNonQuery();
                sw.ExecuteNonQuery();

                Console.WriteLine("Sukses Menambahkan Data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal menambahkan Data. " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
