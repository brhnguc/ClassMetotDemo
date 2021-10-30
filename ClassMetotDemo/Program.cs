using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri {Identity=33333333312, Name ="Emir",Surname="Güç" };

            Musteri musteri2 = new Musteri { Identity = 33334443312, Name = "Ali", Surname = "Karakus" };

            
            

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri2);
            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.ListAll();


        }
    }
}
