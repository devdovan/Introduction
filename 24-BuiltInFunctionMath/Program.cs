namespace _24_BuiltInFunctionMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.PI.ToString());

            int mutlakDeger = Math.Abs(-10);
            Console.WriteLine(mutlakDeger);

            //Kuvvet Alma
            Console.WriteLine(Math.Pow(3,4)); //3 ü 4. kuvvetine alır.

            //KareKök Alma
            Console.WriteLine(Math.Sqrt(16)); //16 sayısının karekökünü alır.

            //Floor: Verilen ondalık değeri bir alt değere tamamlar.
            Console.WriteLine(Math.Floor(3.9)); //3.9 sayısını 3'e tamamlar.

            //Ceiling: Verilen ondalık değeri bir üst değere tamamlar.
            Console.WriteLine(Math.Ceiling(3.1)); //3.1 sayısını 4'e tamamlar.

            //Truncate: Verilen ondalık değerin tam sayı kısmını alır.
            Console.WriteLine(Math.Truncate(12.98)); //12.98 sayısını 12'ye tamamlar.

            //Round = Sayının yarısından fazlasını bir üste yarısından azını bir alta yuvarlar.
            Console.WriteLine(Math.Round(12.65));
            Console.WriteLine(Math.Round(12.45));
            Console.WriteLine(Math.Round(12.50));
            Console.WriteLine(Math.Round(13.50));

            //Sayının pozitif mi negatif mi notr mü olduğunu
            Console.WriteLine(Math.Sign(10)); //10 sayısı pozitif olduğu için 1 döner.
            Console.WriteLine(Math.Sign(-10)); //-10 sayısı negatif olduğu için -1 döner.
            Console.WriteLine(Math.Sign(0)); //0 sayısı nötr olduğu için 0 döner.

            //Max ve Min

            Console.WriteLine(Math.Max(20, 30));
            Console.WriteLine(Math.Min(20, 30));


            //Girilen 3 sayıdan en büyüğünü ve en küçük bulan programı yazınız.

            Console.WriteLine("Sayı1: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Sayı2: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Sayı3: ");
            double num3 = double.Parse(Console.ReadLine());

            Console.WriteLine($"En Büyük: {Math.Max(num3, Math.Max(num1, num2))}");
            Console.WriteLine($"En Küçük: {Math.Min(num3, Math.Min(num1, num2))}");

            //3 Sayı tanımlıyoruz en büyük olan sayıyı buluyoruz Bir dördüncü değişken kullanmadan.
            double sayi1 = 10, sayi2 = 80,
                   sayi3 = 300;
            double max = sayi1;
            if (sayi2 > max)
            {
                max = sayi2;
            }
            if (sayi3 > max)
            {
                max = sayi3;
            }
            Console.WriteLine($"En Büyük Sayı: {max}");


        }
    }
}
