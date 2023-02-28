//	Class Farklı Kullanımı

//	--------------- Ogrenci.cs ---------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS
{
    internal class Ogrenci
    {
        public int yas;
        public string isim;

        public void yazdir()
        {
            Console.WriteLine("{0}.....{1}", yas, isim);
        }
    }
}

//	--------------- Program.cs ---------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLASS
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            (new Ogrenci()).yazdir(); // Referansı olmayan bir nesne oluşturduk ve bu nesneyş kullandık.
            Console.ReadKey();
        }
    }
}

// Ekran Çıktısı:	0.....

/*
    Görüldüğü gibi referansı olmayan bir nesne oluşturk ve o nesneye ait yazdir() fonksiyonunu çağırıp, kullandık.
    Bu yöntem neredeyse hiç kullanılmaz ve sorunlara yol açabilir. 
    Bu örneği yapmaktaki amacımız, aslında kurallarla oynayabildiğimiz göstermektir. Ancak burada yapılan şey kesinlikle LEGAL'dir! :)
*/


