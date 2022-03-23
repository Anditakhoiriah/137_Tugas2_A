using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace _137_Tugas2_A
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
                con = new SqlConnection("data source=ANDITAKHRH\\ANDITAKHRH;database=sewa;Integrated Security = TRUE");
                con.Open();
                SqlCommand cm = new SqlCommand
                ("Create Table Kios (KD_Kios Char(5) not null primary key, Nama_Kios varchar(20) not null, Lokasi varchar(10) not null, Harga_Sewa Char(12) not null)"
                + "Create Table Pelanggan (NIK Char(15) not null primary key, Alamat varchar(50) not null, No_Hp Char(15) not null)"
                + "Create Table Sewa (KD_Sewa Char(5) not null primary key, Durasi varchar(20) not null, Tanggal_Sewa varchar(10) not null, KD_Kios Char(5) not null)"
                + "Create Table Pembayaran (No_Pembayaran Char(5) not null primary key, NIK Char(15) Foreign key references Pelanggan(NIK), KD_Kios Char(5) Foreign key references Kios(KD_Kios), " +
                "KD_Sewa Char(5) Foreign key references Sewa(KD_Sewa), Tanggal_Bayar varchar(10) not null, Jenis_Pembayaran varchar(10) not null, Durasi varchar(10) not null, Bukti_Bayar varchar(10) not null)", con);

                Console.WriteLine("Sukses Menambahkan Data!");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Gagal Menambahkan Data!" + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
    }
}
