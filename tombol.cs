using System;
using System.Collections.Generic;
namespace KerangkaGame
{
    class Karakter
    {
        public int total, power;

        //encapsulation
        public string nama { get; private set; }
        public int kesehatan { get; private set; }
        public int senjata { get; private set; }

        public Karakter(string nama, int kesehatan, int senjata) //membuat constructor
        {
            this.nama = nama;
            this.kesehatan = kesehatan;
            this.senjata = senjata;
        }

        public void Serang(Karakter target) //membuat menthod menyerang
        {
            Console.WriteLine("===> Mulai Serangan <===");
            target.TerimaSerangan(this.senjata);
        }

        public void TerimaSerangan(int jumlahSerangan) // objek menerima serangan
        {
            kesehatan -= jumlahSerangan;
            Console.WriteLine($"{nama} diserang dengan {jumlahSerangan} sisa kesehatannya {kesehatan}");
        }

        public void Healing()
        {
            if (kesehatan <= 0)
            {
                Console.WriteLine($"{nama} sudah mati dan tidak bisa disembuhkan.");
                return;
            }

            Console.Write("Apakah mau disembuhkan? (hm/hmc): ");
            string jawaban = Console.ReadLine().ToLower();

            if (jawaban == "hm")
            {
                kesehatan += 20;
                Console.Write($"{nama} disembuhkan dengan penambahan 20. Kesehatan sekarang: {kesehatan}");
            }
            else if (jawaban == "hmc")
            {
                Console.WriteLine($"{nama} tidak disembuhkan.");
            }
            else
            {
                Console.WriteLine("Tidak ditemukan.");
            }
        }
    

        public void getData()   
        {
            Console.WriteLine($"Karakter : {nama}");
            Console.WriteLine($"Kesehatan : {kesehatan}");
            Console.WriteLine($"Senjata : {senjata}");
        }
    }


    class MainProgram
    {
        static void Main(string[] args)
        {
            Karakter player1 = new Karakter("Luminara", 100, 10);
            Karakter musuh1 = new Karakter("Siti", 80, 50);

            
            //player1.Healing();

            // Pilihan metode perpindahan
            int posisi = 0;

            Console.WriteLine("Mana yang kamu pilih?");
            Console.WriteLine("1. Perpindahan angka");
            Console.WriteLine("2. Tombol keyboard");
            Console.Write("Pilihanmu (1/2): ");

            string pilihan = Console.ReadLine();

            if (pilihan == "1")
            {
                // Perpindahan angka manual
                Console.WriteLine($"Posisi saat ini ada di {posisi}");
                Console.Write("Mau pindah ke posisi berapa? ");

                int tujuan = Convert.ToInt32(Console.ReadLine());

                if (tujuan >= 1)
                {
                    posisi = tujuan;
                    Console.WriteLine($"Posisi saat ini ada di {posisi}");
                }
                else
                {
                    Console.WriteLine("Posisi tidak valid!");
                }
            }
            else if (pilihan == "2")
            {
                // Perpindahan dengan keyboard
                bool aktif = true;

                //Console.WriteLine("\nTekan panah kanan untuk maju 2");
                //Console.WriteLine("Tekan panah kiri untuk mundur 2");
                //Console.WriteLine("Tekan ESC untuk selesai");

                while (aktif)
                {
                    Console.WriteLine($"Posisi saat ini: {posisi}");

                    ConsoleKeyInfo tombol = Console.ReadKey(true);

                    if (tombol.Key == ConsoleKey.RightArrow)
                    {
                        posisi += 2;
                    }
                    else if (tombol.Key == ConsoleKey.LeftArrow)
                    {
                        posisi -= 1;
                    }
                    else if (tombol.Key == ConsoleKey.Escape)
                    {
                        aktif = false;
                        Console.WriteLine("Program selesai!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Pilihan tidak valid!");
            }

            // Interaksi karakter
            player1.Serang(musuh1);
            musuh1.Serang(player1);

        }
    }
}
