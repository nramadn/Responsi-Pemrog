using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek mahasiswa
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan menu
            Console.WriteLine("Menu Aplikasi");
            Console.WriteLine();
            Console.WriteLine("Pilih Menu (1-3)");
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampilkan Mahasiswa");
            Console.WriteLine("3. Keluar");
        }

        static void TambahMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menambahkan objek mahasiswa ke dalam collection
            Console.WriteLine("Tambah Data Mahasiswa");
            Console.WriteLine();

            Console.Write("NIM: ");
            string nim = Console.ReadLine();

            Console.Write("Nama: ");
            string nama = Console.ReadLine();

            Console.Write("Jenis Kelamin [L/P]: ");
            char jenis = Convert.ToChar(Console.ReadLine());

            string jK = "Laki-Laki";
            if (jenis != 'L')
            {
                jK = "Perempuan";
            }

            Console.Write("IPK: ");
            float Ipk = (float)Convert.ToDouble(Console.ReadLine());

            Mahasiswa item = new Mahasiswa
            {
                Nim = nim,
                Nama = nama,
                jenisK = jK,
                IPK = Ipk
            };

            daftarMahasiswa.Add(item);

            Console.WriteLine();

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            Console.Clear();

            // PERINTAH: lengkapi kode untuk menampilkan daftar mahasiswa yang ada di dalam collection
            Console.WriteLine("Data Mahasiswa");
            Console.WriteLine();

            for (int i = 0; i < daftarMahasiswa.Count; i++)
            {
                Mahasiswa item = daftarMahasiswa[i];
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}", i + 1, item.Nim, item.Nama, item.jenisK, item.IPK);
            }

            Console.WriteLine();

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
