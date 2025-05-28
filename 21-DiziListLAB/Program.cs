namespace _21_DiziListLAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Diziler

            string[] sehirler = new string[5] { "Istanbul", "Ankara", "Bursa", "Izmir", "Adana" };
            string sehir = sehirler[3];
            for (int i = 0; i < sehirler.Length; i++)
            {
                Console.WriteLine(sehirler[i]);
            }

            foreach (string item in sehirler)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n" + new string('£', 20) + "*n");

            //Bir sınıftaki 5 öğrencinin notlarını bir diziye kayedecek programı yazınız ve bu notların ortalamasını hesaplayınız.
            string[] ogrenciler = new string[5];
            int[] notlar = new int[5];

            Console.WriteLine($"{ogrenciler.Length} Adet Öğrenci İsmi Giriniz: ");
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine($"{i + 1} Nolu Öğrencinin Adı: ");
                ogrenciler[i] = Console.ReadLine();
            }

            int no = 0;
            foreach (string item in ogrenciler)
            {
                Console.WriteLine($"{item} Adlı Öğrencinin Notu: ");
                notlar[no] = Convert.ToInt32(Console.ReadLine());
                no++;
            }

            Console.WriteLine("\n" + new string('£', 20) + "*n");

            int toplam = 0;
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine($"{ogrenciler[i]} Adlı Öğrencinin Notu: {notlar[i]}");
                toplam += notlar[i];
            }

            int ortalama = toplam / ogrenciler.Length;
            Console.WriteLine($"Öğrencilerin Not Ortalaması: {ortalama}");

            Console.WriteLine("\n" + new string('£', 20) + "*n");

            for (int i = 0; i < ogrenciler.Length; i++)
            {

                if (notlar[i] > ortalama)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{ogrenciler[i]} Adlı Öğrenci Notu: {notlar[i]} Başarılı");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{ogrenciler[i]} Adlı Öğrenci Notu: {notlar[i]} Başarısız");
                }
                Console.ResetColor();
            }
            #endregion

            Console.WriteLine("\n" + new string('£', 20) + "\n");

            #region Listeler
            List<string> list = new List<string>() { "Ahmet", "Mustafa", "Burak" };
            list.Add("Büşra");
            list.Add("Melisa");
            Console.WriteLine(list.Count);
            Console.WriteLine(list[2]);

            list.Remove("Mustafa");

            Console.WriteLine(list.Count);
            Console.WriteLine(list[2]);

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //Kullanıcıdan alınan ürünlerle bir alışveriş listesi oluşturan program yazıyoruz.
            List<string> alisverisListesi = new List<string>();
            bool devamMi = false;
            string urun;

            do
            {
                Console.WriteLine("Listeye eklemek istediğiniz ürünü giriniz (çıkmak için 'çık' yazınız): ");
                urun = Console.ReadLine();

                if (urun != "çık")
                {
                    alisverisListesi.Add(urun);
                    devamMi = true;
                }
                else
                    devamMi = false;
            }
            while (devamMi);

            Console.WriteLine("\nAlışveriş Listesi: ");

            foreach (var item in alisverisListesi)
            {
                Console.WriteLine(item);
            }

            bool aldinMi = true;

            while (aldinMi)
            {
                Console.WriteLine("\nAlınan ürün var mı?");
                urun = Console.ReadLine();

                if (alisverisListesi.IndexOf(urun) <= -1)
                {
                    Console.WriteLine($"{urun} ürün listende yok.");
                }
                else
                {
                    alisverisListesi.Remove(urun);
                    Console.WriteLine("Kalan ürünler: ");
                    foreach (var item in alisverisListesi)
                    {
                        Console.WriteLine(item);
                    }
                }

                Console.WriteLine("Programı kapatmak istiyor musun? [yes] [no]");
                aldinMi = Console.ReadLine().ToLower() == "yes" ? false : true;
            }
            #endregion
        }
    }
}
