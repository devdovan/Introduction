using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace _03_DegiskenlerAnonimTipler
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Object,Var,Dynamic

            #region Object

            //Object: Tüm tüplerin atasıdır.
            //Object tipi genellikle çok çeşitli veri türleriyle çalışırken kullanılır.
            //Herhangi bir tipteki veriyi tutabilir. Ancak, kullanırken tip dönüşümü yapmamız gerekir.
            object a = 10;
            object b = 'k';
            object c = "metin";
            object d = 10.5;
            Console.WriteLine((int)a * 2);

            #endregion

            #region Var
            //Compile Time ve Run Time
            //Compile Time: Derleme zamanı
            //Run Time: Çalışma zamanı
            //Var,derleme zamanında atanan verinin tipine dönüşür
            //Var: Derleyiciye tipini belirlemesini söyler.
            //Var kullanırken, değişkenin ilk değerini atamak zorundayız.
            //Var, sadece local scope'da kullanılabilir.
            //null atanamaz: var x = null; geçersizdir çünkü tür çıkartılamaz.
            //Okunabilirlik açısından karmaşık türlerde faydalıdır, ama basit türlerde tartışmalı olabilir
            var a1 = 10;
            var b1 = 'k';
            var c1 = "metin";
            var d1 = 10.5;

            Console.WriteLine(a1 * 2);

            #endregion

            #region Dynamic
            //Compile Time ve Run Time
            //Compile Time: Derleme zamanı
            //Run Time: Çalışma zamanı
            //Dynamic: Derleme zamanında değil, çalışma zamanında tipini belirler.
            //Dynamic, çalışma zamanında tipini belirler.
            //Dynamic, derleyiciye tipini belirlemesini söylemez.
            //Dynamic, her türdeki veriyi tutabilir.
            //Dynamic, tüm türlerde kullanılabilir.
            //Dynamic, null atanabilir.
            //Dynamic, var'dan daha esnektir ama daha yavaştır.
            dynamic a2 = 10;
            dynamic b2 = 'k';
            dynamic c2 = "metin";
            dynamic d2 = 10.5;
            Console.WriteLine(a2 * 2);

            #endregion

            #region DataTime

            // DateTime.Now
            //Yerel(Local) saat bilgisini verir.
            //Bilgisayarın ayarlı olduğu zaman dilimine(time zone) göre çalışır.
            //Örnek: Türkiye'deysen ve saat 13:00'sa, DateTime.Now da 13:00 verir.

            DateTime now;
            now = DateTime.Now;
            Console.WriteLine(now);

            // DateTime.UtcNow
            //UTC (Coordinated Universal Time) zamanını verir.
            //Koordinatlı Evrensel Zaman (UTC) saat bilgisini verir.
            //UTC, Greenwich Mean Time (GMT) ile aynı anlama gelir.
            //UTC, dünya genelinde standart bir zaman dilimidir.
            //Türkiye UTC+3 olduğu için Örnek: Türkiye'de saat 13:00 ise, DateTime.UtcNow büyük ihtimalle 10:00 olur.

            DateTime now1;
            now1 = DateTime.UtcNow;
            Console.WriteLine(now1);

            #endregion
        }
    }
}
