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



        //public void Aksi()
        //{
        //    int posisi = 0;

        //    Console.WriteLine($"Posisi saat ini ada di {posisi}");
        //    Console.Write("Mau pindah ke posisi berapa? ");
        //    int tujuan = Convert.ToInt32(Console.ReadLine());

        //    if (tujuan >= 1)
        //    {
        //        posisi = tujuan;
        //        Console.WriteLine($"Posisi saat ini ada di {posisi}");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Posisi tidak valid!");
        //    }
        //}



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


    //class MainProgram
    //{
    //    static void Main(string[] args)
    //    {
    //        Karakter player1 = new Karakter("Luminara", 100, 10); // player utama
    //        Karakter musuh1 = new Karakter("Siti", 80, 50); //Musuh


    //        //interaksi
    //        player1.Serang(musuh1);
    //        musuh1.Serang(player1);
    //        player1.Aksi();
    //        player1.Healing();
    //    }
    //}

    class MainProgram
    {
        static void Main(string[] args)
        {
            Karakter player1 = new Karakter("Luminara", 100, 10);
            Karakter musuh1 = new Karakter("Siti", 80, 50);

            // Interaksi karakter
            player1.Serang(musuh1);
            musuh1.Serang(player1);

            player1.Healing();

            // Pergerakan karakter
            int posisi = 0;
            bool aktif = true;

            Console.WriteLine("");

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
    }

}
