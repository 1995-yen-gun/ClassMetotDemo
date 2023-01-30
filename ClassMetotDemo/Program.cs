using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Name= "Fevzi Ataman";
            musteri1.Description = "Mardin Şube";
            musteri1.Job = "Çiftçi";

            Musteri musteri2 = new Musteri();
            musteri2.Name = "Canan Beyzagil";
            musteri2.Description = "Samsun Şube";
            musteri2.Job = "Öğretmen";
          
            Musteri musteri3 = new Musteri();
            musteri3.Name = "Adnan Onal";
            musteri3.Description = "Rize Şube";
            musteri3.Job = "Mühendis";

            MusteriManager.Ekle(musteri1);
            MusteriManager.Ekle(musteri2);
            MusteriManager.Ekle(musteri3);

            Console.WriteLine( " ************************ ");


            Console.WriteLine();
            MusteriManager.Listele(musteri1,musteri2,musteri3);

            Console.WriteLine("**********************");

            MusteriManager.Sil(musteri1);
            MusteriManager.Sil(musteri2);

            Console.WriteLine("*************************");
        }
    }
}
