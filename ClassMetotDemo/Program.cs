using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Name = "Fırat";
            musteri1.SurName = "Mikyaz";
            musteri1.DateBirthDay = "01.08.1991";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Name = "Mustafa";
            musteri2.SurName = "Akçakaya";
            musteri2.DateBirthDay = "05.11.1995";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            Console.WriteLine("*********************");
            musteriManager.List(musteriler);
            Console.WriteLine("*********************");
            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);
        }
    }
}
