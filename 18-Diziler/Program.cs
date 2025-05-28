namespace _18_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sehir1 = "İstanbul";
            string sehir2 = "Ankara";
            string sehir3 = "İzmir";

            string[] sehirler = { "İstanbul", "Ankara", "İzmir" };
            Console.WriteLine(sehirler[2]);

            //diziler aynı tipte değerlerin taşınmasını sağlayan referans tipli yaplılardır. Dizilerin en önemli özelliği elemanlarını ismiyle değil index sırasıyla erişim sağlamasıdır.
            //Dizi oluştururken ya eleman sayısını ya da elemanlarını belirtmek zorundayız. Çünkü referans tipli olduklarından dolayı belleğin heap kısmında kendine belirli bir boyutta alan açmak zorundadırlar.

            int[] sayilar = new int[5] { 70, 54, 34, 87, 45 };
            Console.WriteLine(sayilar[3]);

            double[] notlar;
            notlar = new double[5];
            notlar[0] = 20;
            notlar[1] = 30;
            notlar[2] = 40;

            Console.WriteLine(notlar[2]);

            notlar = new double[10];

            Console.WriteLine(notlar[2]);
            notlar[0] = 20;
            notlar[1] = 10;
            notlar[7] = 30;

            //Dizi Tanımla
            int[] numbers = new int[5]; //Tanımlama-1 Boyut belirleme zorunluluğu
            int[] numbers2 = { 20, 15, 45, 55 }; //Tanımlama-2 Elemanları belirleme zorunluluğu
            int[] numbers3 = new int[5] { 10, 30, 25, 0, 50 }; //Tanımlama-3 Hem boyut hem de elemanları belirleme zorunluluğu

            //Dizi Elemanlarına Erişim
            numbers[2] = 5; //Dizinin 2. indexine 5 değerini yazdık.
            int num = numbers[2]; //Dizinin 2. indexindeki değeri num değişkenine atadık. Diziden eleman okumak

            Console.WriteLine("\n" + new string('*', 20) + "\n");

            //Dizinin Tüm Elemanlarına Erişim

            string[] cars = new string[7] { "TOGG", "TESLA", "MG", "Mercedes", "BMW", "AUDI", "VOLKSWAGEN" };

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }


            //Foreach Döngüsü ile Dizi Elemanlarına Erişim
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }

            foreach (int item in "busra dovan")
            {
                Console.WriteLine(item);
            }


            //objects
            object[] objects = new object[5] { 10, "Adı", true, 5.2, 'c' };
            int[] deneme = new int[3] { 10, 20, 30 };

            Console.WriteLine(deneme[0] * 3);
            Console.WriteLine((int)objects[0] * 2);

            Console.WriteLine("\n" + new string('$', 20) + "\n");

            #region Ornek-1

            //10 elemanlı bir sayı dizisi tanımlayın
            //Dizinin tüm elemanlarını ekarana yazdırın.
            //dizinin toplam değerini ekrana yazdırın.

            int[] sayiDizisi = new int[10] { 5, 2, 5, 6, 8, 1, 9, 0, 4, 3 };

            foreach (int sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            int toplam = 0;
            for (int i = 0; i < sayiDizisi.Length; i++)
            {
                toplam += sayiDizisi[i];
            }

            Console.WriteLine("Toplam: " + toplam);
            #endregion

            Console.WriteLine("\n" + new string('#', 20) + "\n");
            #region Ornek-2
            //Bir öğrencinin bir derse ait notlarının hesaplandığı bir program yazın.
            Console.WriteLine("Büşra'nın Programlama-I Dersi Notları. ");
            Console.WriteLine("Programlama-I dersinden kaç tane not girişi yapmak istiyorsunuz: ");
            int adet = int.Parse(Console.ReadLine());
            double[] notlarim = new double[adet];
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine("Lütfen " + (i + 1) + ". notunuzu giriniz: ");
                int not = int.Parse(Console.ReadLine());
                notlarim[i] = not;
            }
            Console.WriteLine("Notlar");
            foreach (double not in notlarim)
            {
                Console.WriteLine(not);
            }

            double toplamNot = 0;
            for (int i = 0; i < notlarim.Length; i++)
            {
                toplamNot += notlarim[i];
            }
            Console.WriteLine("Ortalama: " + toplamNot / notlarim.Length);
            #endregion
        }
    }
}
