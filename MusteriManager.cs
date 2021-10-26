using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi :"+ musteri.Adi+ " " +musteri.Soyadi);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi :"+musteri.Adi+ " "+musteri.Soyadi);
        }
        public void List(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listelendi :"+musteri.Id+" "+musteri.Adi+" "+musteri.Soyadi);
        }
    }
}
