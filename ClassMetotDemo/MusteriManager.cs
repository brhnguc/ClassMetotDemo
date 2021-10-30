using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        
        public void Add(Musteri musteri)

        {
            Console.WriteLine(musteri.Name + " isimli müşteri sistemimize eklenmiştir."); 
          
        }
        
        public void Delete(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + "isimli müşteri sistemimizden çıkartılmıştır");
        }


        public void ListAll()
        {
            Console.WriteLine("Müşteriler listelendi!");
        }
    }
}
