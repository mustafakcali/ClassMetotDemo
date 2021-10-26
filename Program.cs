using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Buket";
            musteri1.Soyadi = "Çiçek";
            musteri1.TcNo = 1111111111;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Mustafa";
            musteri2.Soyadi = "Akçalı";
            musteri2.TcNo = 1111111112;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Ahmet";
            musteri3.Soyadi = "Atmaca";
            musteri3.TcNo = 1111111122;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "Mert";
            musteri4.Soyadi = "Lüy";
            musteri4.TcNo = 1111111222;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.TcNo);
                
            }
            
            
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Delete(musteri2);
            musteriManager.List(musteri4);
            
            
        }
    }
}
