// C#'da namespace kullanımı

using System;

namespace first_space {
   class namespace_cl {
      public void func() {
         Console.WriteLine("Inside first_space");
      }
   }
}
namespace second_space {
   class namespace_cl {
      public void func() {
         Console.WriteLine("Inside second_space");
      }
   }
}
class TestClass {
   static void Main(string[] args) {
      first_space.namespace_cl fc = new first_space.namespace_cl();
      second_space.namespace_cl sc = new second_space.namespace_cl();
      fc.func();
      sc.func();
      Console.ReadKey();
   }
}
/*
TestClass isimli Class yapısı incelendiğinde
   first_space.namespace_cl fc = new first_space.namespace_cl();
   second_space.namespace_cl sc = new second_space.namespace_cl();
   
Kodları ile karşılaşmaktayız. Burada görüldüğü üzere, 
   new first_space.namespace_cl();
ifadesi ile first_space içerisinde bulunan namespace_c1 içerisinde bulunan class çağrılmışitır.
Çağırma işlemi (.) operatörü ile sağlanmıştır.

Yukarıdaki kod derlenip yürütüldüğünde, aşağıdaki sonucu verir −
Inside first_space
Inside second_space
*/
