namespace _11_DongulerForDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Döngülerin genel amacı belirli bir kod bloğunu tekrarlamaktır.
               -For Döngüsü (*Adet,Sayı - Önemli olan bir miktar). For döngüsü, belirli bir sayıda tekrarlamak için kullanılır.
                -While Döngüsü (*Koşul - Önemli olan bir koşul). While döngüsü, belirli bir koşul sağlandığı sürece tekrarlamak için kullanılır.
                -Do While Döngüsü (*Koşul - Önemli olan bir koşul). Do while döngüsü, belirli bir koşul sağlandığı sürece tekrarlamak için kullanılır. Ancak, en az bir kez çalışır.
                -foreach Döngüsü (*Dizi, Liste - Önemli olan bir koleksiyon). Foreach döngüsü, bir koleksiyonun her bir elemanını teker teker işlemek için kullanılır.
            
             */

            //For Döngüsü: Belirli bir miktar geçerli olduğu sürece belirli bir kod bloğunu tekrar çalıştırmak için kullanılan kontrol yapısıdır. (Genellikle belirli bir syaıda tekrarlanan işlem yapmak için kullanılır.)

            //(Başlangıç Değeri - Koşul - Artış/Değişim)

            for (int deger = 5; deger <= 50; deger += 5)
            {
                Console.WriteLine(deger);
            }

            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine(i);
            }

            //Sonsuz Döngüler
            //for (int i = 0; i < 100; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //for (; ;)
            //{
            //    Console.WriteLine("Biri beni durdursun");
            //}

            #region Ornek-1

            //1 den 100 kadar olan çift sayıların toplamını ekrana yazdıran program.

            int ciftSayilarToplami = 0;
            for (int i = 0; i < 100; i += 2)
            {
                ciftSayilarToplami += i;
            }

            Console.WriteLine("1 den 100 kadar olan çift sayıların toplamı: " + ciftSayilarToplami);

            #endregion

            #region Ornek-2
            //1 den 100 kadar olan çift sayıların toplamı ile tek sayıların toplamını ekrana yazdıran program.

            int tekSayilarinToplami = 0;
            int ciftSayilarinToplami = 0;

            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    ciftSayilarinToplami += i;
                }
                else
                {
                    tekSayilarinToplami += i;
                }
            }
            Console.WriteLine("Çift Sayıların Toplamı: {0}\nTek Sayıların Toplam: {1}", ciftSayilarinToplami, tekSayilarinToplami);
            #endregion

            #region Ornek-3
            //100 den 0'a kadar olan sayıların hem 3 hemde 7 bölünenleri ekrana yazdır.
            for (int i = 100; i >= 0; i--)
            {
                if (i % 3 == 0 && i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion

            #region Ornek-4

            for (char i = 'A'; i < 'Z'; i++)
            {
                Console.WriteLine((int)i + " " + i);
            }

            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(i + " X " + j + " = " + i * j);
                }
                Console.WriteLine("");
            }
            #endregion

            #region Ornek-5
            //Kullanıcıdan aldığı uzunluk bilgisine göre ekrana dikdörtgen çizen uygulama.

            Console.WriteLine("Uzunluk-1: ");
            int uzunluk1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Uzunluk-2: ");
            int uzunluk2 = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Magenta;
            for (int i = 0; i <= uzunluk1; i++)
            {
                for (int j = 0; j <= uzunluk2; j++)
                {
                    Console.Write("*");
                    Thread.Sleep(500);
                    Console.Beep();
                }
                Console.WriteLine("");
            }
            Console.ResetColor();
            #endregion

        }
    }
}
