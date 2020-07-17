using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using UASPemrograman.Mahasiswa1;

namespace UASPemrograman
{
    class Program
    {
        static void Main()
        {
            List<Mahasiswa> mahasiswa = new List<Mahasiswa>();

            Pilih(mahasiswa);
        }

        static void Pilih(List<Mahasiswa> mahasiswa)
        {
            bool status = true;
            int pil;
            while (status == true)
            {
            A:
                try
                {
                    Console.Clear();
                    Console.WriteLine("======================================================");
                    Console.WriteLine("=== SELAMAT DATANG DI PROGRAM INPUT DATA MAHASISWA ===");
                    Console.WriteLine("============= UNIVERSITAS KENANGAN ABADI =============");
                    Console.WriteLine("======================================================");
                    Console.WriteLine("Menu Utama : ");
                    Console.WriteLine("[1]. Tambah Data\n[2]. Hapus Data");
                    Console.WriteLine("[3]. Tampilkan Data \n[4]. Keluar");
                    Console.WriteLine("======================================================");
                    Console.Write("Masukkan Pilihan Anda[1-4]: ");
                    pil = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Error: Pilihan Harus 1-4");
                    Console.WriteLine("\nPress Any Key To Retry.");
                    Console.ReadKey();
                    goto A;
                }

                switch (pil)
                {
                    case 1:
                        {
                            TambahData(mahasiswa);
                            BackToMainMenu();
                            break;
                        }

                    case 2:
                        {
                            HapusData(mahasiswa);
                            BackToMainMenu();
                            break;
                        }

                    case 3:
                        {
                            TampilData(mahasiswa);
                            BackToMainMenu();
                            break;

                        }

                    case 4:
                        {
                            Console.WriteLine("Good Bye.");
                            Thread.Sleep(500);
                            status = false;
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Pilihan tidak ada, silahkan masukkan pilihan yang ada.\nPress Any Button");
                            Console.ReadKey();
                            Pilih(mahasiswa);
                            break;
                        }
                }
            }
        }

        static void TambahData(List<Mahasiswa> mahasiswa)
        {
            int pil;
            B:
            try
            {
                Console.Clear();
                Console.WriteLine("=========== Menu Menambah Mahasiswa ===========");
                Console.WriteLine("\nPilih Status Mahasiswa: ");
                Console.WriteLine("[1] Aktif \n[2] Lulus \n[3] Cuti \n[4] DO");
                Console.Write("Masukkan Pilihan Anda [1-4]: ");
                pil = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Error: Pilihan Harus 1-4");
                Console.WriteLine("\nPress Any Key To Retry.");
                Console.ReadKey();
                goto B;
            }

            switch (pil)
            {
                case 1:
                    {
                        StatusAktif aktif = new StatusAktif();

                        Console.WriteLine("\nTambah mahasiswa aktif");

                        Console.Write("Masukkan NIM            : ");
                        aktif.NIM = Console.ReadLine();

                        Console.Write("Masukkan Nama Mahasiswa : ");
                        aktif.Nama = Console.ReadLine();

                        Console.Write("Masukkan Kelas          : ");
                        aktif.Kelas = Console.ReadLine();

                        Console.Write("Masukkan Prodi          : ");
                        aktif.Prodi = Console.ReadLine();

                        mahasiswa.Add(aktif);
                        break;
                    }

                case 2:
                    {
                        StatusLulus lulus = new StatusLulus();

                        Console.WriteLine("\nTambah mahasiswa yang sudah lulus");

                        Console.Write("Masukkan NIM            : ");
                        lulus.NIM = Console.ReadLine();

                        Console.Write("Masukkan Nama Mahasiswa : ");
                        lulus.Nama = Console.ReadLine();

                        Console.Write("Masukkan Kelas          : ");
                        lulus.Kelas = Console.ReadLine();

                        Console.Write("Masukkan Prodi          : ");
                        lulus.Prodi = Console.ReadLine();

                        mahasiswa.Add(lulus);
                        break;
                    }

                case 3:
                    {
                        StatusCuti cuti = new StatusCuti();

                        Console.WriteLine("\nTambah mahasiswa yang sedang cuti");

                        Console.Write("Masukkan NIM            : ");
                        cuti.NIM = Console.ReadLine();

                        Console.Write("Masukkan Nama Mahasiswa : ");
                        cuti.Nama = Console.ReadLine();

                        Console.Write("Masukkan Kelas          : ");
                        cuti.Kelas = Console.ReadLine();

                        Console.Write("Masukkan Prodi          : ");
                        cuti.Prodi = Console.ReadLine();

                        mahasiswa.Add(cuti);
                        break;
                    }

                case 4:
                    {
                        StatusDO dropout = new StatusDO();

                        Console.WriteLine("\nTambah mahasiswa yang DO");

                        Console.Write("Masukkan NIM            : ");
                        dropout.NIM = Console.ReadLine();

                        Console.Write("Masukkan Nama Mahasiswa : ");
                        dropout.Nama = Console.ReadLine();

                        Console.Write("Masukkan Kelas          : ");
                        dropout.Kelas = Console.ReadLine();

                        Console.Write("Masukkan Prodi          : ");
                        dropout.Prodi = Console.ReadLine();

                        mahasiswa.Add(dropout);
                        break;
                    }

                default:
                    {
                        Console.WriteLine("Pilihan tidak ada, silahkan masukkan lagi.\nPress Any Button");
                        Console.ReadKey();
                        TambahData(mahasiswa);
                        break;
                    }
            }
        }

        static void HapusData(List<Mahasiswa> mahasiswa)
        {
            bool Ditemukan = true;

            TampilData(mahasiswa);
            Console.Write("\nMasukkan NIM Mahasiswa yang ingin dihapus: ");
            string Nim = Console.ReadLine();

            for (int i = 0; i < mahasiswa.Count; i++)
            {
                if (mahasiswa[i].NIM == Nim)
                {
                    mahasiswa.Remove(mahasiswa[i]);
                    Ditemukan = true;
                    break;
                }
                else
                {
                    Ditemukan = false;
                }
            }

            switch (Ditemukan)
            {
                case true:
                    Console.WriteLine("\nMahasiswa dengan NIM = \"{0}\" berhasil dihapus", Nim);
                    break;
                case false:
                    Console.WriteLine("\nMahasiswa dengan NIM = \"{0}\" tidak ditemukan", Nim);
                    break;
            }
        }

        static void TampilData(List<Mahasiswa> mahasiswa)
        {
            string line = "=";
            char l = '=';
            Console.Clear();

            Console.Write("================================================");
            Console.Write(" DATA MAHASISWA");
            Console.WriteLine(" ===============================================");
            Console.WriteLine(line.PadLeft(111, l));
            Console.WriteLine(String.Format("| {0,-1} | {1,-10} | {2,-25} | {3,-20} | {4,-25} | {5,-10} |", "NO", "NIM", "NAMA", "KELAS", "PRODI", "STATUS"));
            Console.WriteLine(line.PadLeft(111, l));
            for (int i = 0; i < mahasiswa.Count; i++)
            {
                Console.WriteLine(String.Format("| {0,-2} | {1,-10} | {2,-25} | {3,-20} | {4,-25} | {5, -10} |",
                    i + 1, mahasiswa[i].NIM, mahasiswa[i].Nama, mahasiswa[i].Kelas, mahasiswa[i].Prodi, mahasiswa[i].Status()));
            }
        }

        static void BackToMainMenu()
        {
            Console.WriteLine("\nPress Any Key To Back To The Main Menu.");
            Console.ReadKey();
        }
    }
}