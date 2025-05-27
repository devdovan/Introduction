namespace _17_AtlamaOperatorleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atlama ifadeleri (Jump Statements) program kontrolü üzeride akışta dallanamalar sağlamak için kullanılır.
            //- Break
            //- Continue
            //- Goto
            //- Return
            //- Throw

            #region Break

            //Break anahtar kelimesi döngü içinde kullanıldığı zaman bir daha dönmemek üzere döngünün sonuna gönderir.
            for (int x = 0; x < 10; x++)
            {
                if (x == 5)
                {
                    break; // Döngüden çık
                }
                Console.WriteLine(x);
            }

            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    if (i == 5)
                    {
                        break;
                    }

                    Console.WriteLine(i + "_" + i2);
                }
            }
            #endregion

            #region Continue

            //Bir tur atlar. anahtar kelime kendisini çevreleyen en yakın döngününün başına transfer eder.
            for (int m = 0; m < 10; m++)
            {
                if (m == 5)
                {
                    continue; // Döngünün başına git
                }
                Console.WriteLine(m);
            }
            #endregion

            #region GoTo

            //Goto anahtar kelimesi program akışını etiketli bir noktaya yönlendirmek için kullanılır.
            //Goto kullanımı genellikle önerilmez çünkü kodun okunabilirliğini azaltır ve karmaşık hale getirebilir.
            int l = 0;
        loop:
            Console.WriteLine(l);
            l++;
            if (l < 10)
            {
                goto loop; // loop etiketine git
            }
            #endregion

            #region Throw

            //Throw anahtar kelimesi, bir istisna (exception) fırlatmak için kullanılır.
            //Bu, programın normal akışını keser ve istisna işleme mekanizmasını devreye sokar.
            for (int k = 0; k < 10; k++)
            {
                if (k == 5)
                {
                    throw new Exception("5 sevmedim..");
                }

                Console.WriteLine(k);
            }
            #endregion
        }
    }
}
