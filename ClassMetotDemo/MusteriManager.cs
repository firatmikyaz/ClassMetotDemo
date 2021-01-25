using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine(musteri.Id + " - " + musteri.Name + " " +musteri.SurName + "\n" + musteri.DateBirthDay);
            Console.WriteLine(musteri.Id + " Id'li Müşteri Eklendi.");
        }
        public void List(Musteri[] musteriler) 
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id + " " + musteri.Name + " " +musteri.SurName + " "+ musteri.DateBirthDay);
                Console.WriteLine("Müşteriler Listelendi.");
            }
        }
        public void Delete(Musteri musteri) 
        {
            Console.WriteLine(musteri.Id + " " + musteri.Name + " " + musteri.SurName + " " + musteri.DateBirthDay);
            Console.WriteLine("Müşteriler Silindi.");
        }
    }
}
