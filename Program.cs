using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Program
    {
        static List<Karyawan> listKaryawan = new List<Karyawan>();
        static void Main(string[] args)
        {
            Console.Title = "Final Project Pemrograman";

            bool ulang = true;
            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..4]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahData();
                        break;

                    case 2:
                        HapusData();
                        break;

                    case 3:
                        TampilData();
                        break;

                    case 4:
                        ulang = false;
                        return;

                    default:
                        Console.Clear();
                        Console.WriteLine("Menu Tidak Ada");
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("=================================================");
            Console.WriteLine("\tSistem Penghitungan Karyawan");
            Console.WriteLine("=================================================\n");
            Console.WriteLine("Pilih Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("1. Tambah Produk");
            Console.WriteLine("2. Hapus Produk");
            Console.WriteLine("3. Tampilkan Produk");
            Console.WriteLine("4. Keluar");
        }

        static void TambahData()
        {
            Console.Clear();
            Console.WriteLine("Tambah Data Karyawan\n");
            Console.Write("Jenis Karyawan[1. PNS, 2. Guru, 3. Guru Honorer] : ");
            int pil = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (pil)
            {
                case 1:
                    PNS pns = new PNS();
                    Console.Write("NIP : ");
                    pns.NIP = Console.ReadLine();
                    Console.Write("Nama : ");
                    pns.Nama = Console.ReadLine();
                    Console.Write("Gaji Bulanan : ");
                    pns.Bulanan = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Gaji Per Tahun : ");
                    pns.GajiPerTahun = Convert.ToDouble(Console.ReadLine());
                    listKaryawan.Add(pns);
                    break;
                case 2:
                    Guru guru = new Guru();
                    Console.Write("NIP : ");
                    guru.NIP = Console.ReadLine();
                    Console.Write("Nama : ");
                    guru.Nama = Console.ReadLine();
                    Console.Write("Gaji Bulanan : ");
                    guru.GajiBulanan = Convert.ToDouble(Console.ReadLine());
                    listKaryawan.Add(guru);
                    break;
                case 3:
                    Honorer honorer = new Honorer();
                    Console.Write("NIP : ");
                    honorer.NIP = Console.ReadLine();
                    Console.Write("Nama : ");
                    honorer.Nama = Console.ReadLine();
                    Console.Write("Jumlah Jam Kerja : ");
                    honorer.JumlahJamKerja = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Upah Per Jam : ");
                    honorer.UpahPerJam = Convert.ToDouble(Console.ReadLine());
                    listKaryawan.Add(honorer);
                    break;
                default:
                    Console.WriteLine("Menu Yang Anda Masukkan Salah!!!");
                    break;
            }
        }

        static void HapusData()
        {
            Console.Clear();

            int nomor = -1, hapus = -1;
            Console.Write("Hapus Data\n");
            Console.Write("NIP : ");
            string code = Console.ReadLine();
            foreach (Karyawan karyawan in listKaryawan)
            {
                nomor++;
                if (karyawan.NIP == code)
                {
                    hapus = nomor;
                }
            }

            if (hapus != -1)
            {
                listKaryawan.RemoveAt(hapus);
                Console.WriteLine("\nData dapat dihapus");
            }

            else
            {
                Console.WriteLine("\nNIP tidak dapat ditemukan");
            }

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilData()
        {
            Console.Clear();

            int noUrut = 0;
            string jenis = " ";
            Console.WriteLine("Data Karyawan\n");
            foreach (Karyawan karyawan in listKaryawan)
            {
                if (karyawan is PNS)
                {
                    jenis = "Pegawai Negeri Sipil";
                }
                else if (karyawan is Guru)
                {
                    jenis = "Guru";
                }
                else
                {
                    jenis = "Guru Honorer";
                }
                noUrut++;
                Console.WriteLine("{0}. NIP: {1}, Nama: {2}, Gaji: {3:}, {4}", noUrut, karyawan.NIP, karyawan.Nama, karyawan.Gaji(), jenis);
            }
            if (noUrut < 1)
            {
                Console.WriteLine("Data Karyawan Kosong");
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
