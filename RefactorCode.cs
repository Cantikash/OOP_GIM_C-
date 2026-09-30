//game
//karakter : nama, kesehatan, 
//setter yaitu utk mengisi atrbut
//this utk menunjuk var di dalem class

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
        public string senjata { get; private set; }

        public Karakter(string nama, int kesehatan, string senjata) //membuat constructor
        {
            this.nama = nama;
            this.kesehatan = kesehatan;
            this.senjata = senjata;
        }
        //public void setData(string namaBaru, string statusKesehatan, string senjataBaru, int totalSenjata, int powerr)
        //{
        //    this.nama = namaBaru;
        //    this.kesehatan = statusKesehatan;
        //    this.senjata = senjataBaru;
        //    this.total = totalSenjata;
        //    this.power = powerr;
        //}

        //public void getData()
        //{
        //    Console.Write(nama);
        //    Console.Write(" / ");
        //    Console.Write(kesehatan);
        //    Console.Write(" / ");
        //    Console.Write(senjata);
        //    Console.Write(" / ");
        //    Console.Write(total);
        //    Console.Write(" / ");
        //    Console.WriteLine(power);
        //}

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
            Karakter player1 = new Karakter("Luminara", 80, "Tembakan");
            player1.getData();

            //Kode Sebelumnya
            //List<Karakter> daftarHero = new List<Karakter>(); //array menyimpan pahlawan
            //Karakter player1 = new Karakter();
            //player1.setData("Player : Archer", "Sehat", "Palu", 56, 100);
            ////player1.getData();

            //Karakter player2 = new Karakter();
            //player2.setData("Player : Goblin", "Mati", "Batu", 0, 25);
            ////player2.getData();

            //Karakter enemy = new Karakter();
            //enemy.setData("Musuh : Barbarian", "Kritis", "Tembakan", 10, 300);
            //enemy.getData();

            //daftarHero.Add(player1);
            //daftarHero.Add(player2);

            ////menampilkan data dari array, foreach
            //foreach(Karakter player in daftarHero)
            //{
            //    player.getData();
            //}

        }
    }
}
