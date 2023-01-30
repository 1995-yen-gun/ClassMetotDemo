using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public static void Ekle (Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " isimli müşteri sisteme eklendi. ");
            Console.WriteLine(musteri.Description );
            Console.WriteLine(musteri.Job);
        }

        public static void Listele  (params Musteri[] musteris) 
        {
        foreach(Musteri musteri in musteris)
            {
                Console.WriteLine(musteri.Name + " isimli müşteri sistemde kayıtlıdır. ");
                Console.WriteLine(musteri.Description);
                Console.WriteLine(musteri.Job);
            }
        }
        public static void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Name + " isimli müşteri sistemden silindi. ");
            Console.WriteLine(musteri.Description);
            Console.WriteLine(musteri.Job);
        }
    }

}
