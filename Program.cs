using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPolyDanCol
{
    class Program
    {
        static void Main(string[] args)
        {
            KaryawanTetap karyawanTetap = new KaryawanTetap();
            karyawanTetap.NIK = "121-121-121";
            karyawanTetap.Nama = "Ericko Lim";
            karyawanTetap.GajiBulanan = 9100000;

            KaryawanHarian karyawanHarian = new KaryawanHarian();
            karyawanHarian.NIK = "454-454-454";
            karyawanHarian.Nama = "Udil Surbakti";
            karyawanHarian.JumlahJamKerja = 20;
            karyawanHarian.UpahPerJam = 6600;

            Sales sales = new Sales();
            sales.NIK = "656-656-656";
            sales.Nama = "Brandon Kent";
            sales.JumlahPenjualan = 15;
            sales.Komisi = 3300;

            List<Karyawan> listKaryawan = new List<Karyawan>();

            listKaryawan.Add(karyawanTetap);
            listKaryawan.Add(karyawanHarian);
            listKaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listKaryawan)
            {
                Console.WriteLine("{0}. NIK: {1}, Nama: {2}, Gaji: {3:N0}",
                noUrut, karyawan.NIK, karyawan.Nama, karyawan.Gaji());

                noUrut++;
            }

            Console.ReadKey();
        }
    }
}
