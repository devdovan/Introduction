namespace _19_DiziOzellikleriveMetotları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi Properties(Özellikler) and Methods(Metotlar)

            string[] sehirler = { "İstanbul", "Ankara", "İzmir", "Bursa", "Trabzon", "Eskisehir", "Konya", "Sivas", "Eskisehir" };
            #region Length

            // Length Özelliği: Dizinin eleman sayısını(boyutunu) verir.
            Console.WriteLine($"Dizinin Boyutu: {sehirler.Length}");
            foreach (string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
            #endregion

            Console.WriteLine("\n" + new string('#', 20) + "\n");

            #region Clear

            // Clear Metodu: Dizinin elemanlarını temizler. İstenilen eleman sayısı kadar temizler.
            //Array.Clear(sehirler);
            //Array.Clear(sehirler, 3, 2); // 3. indexten başlayarak 2 elemanı temizler.
            //foreach (string sehir in sehirler)
            //{
            //    Console.WriteLine(sehir);
            //}
            #endregion

            Console.WriteLine("\n" + new string('#', 20) + "\n");

            #region Sort

            // Sort Metodu: Dizinin elemanlarını küçkten büyüğe doğru sıralar.
            Array.Sort(sehirler);
            Array.Sort(sehirler, 3, 4); // 3. indexten başlayarak 4 elemanı sıralar.
            foreach (string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            #endregion

            Console.WriteLine("\n" + new string('#', 20) + "\n");

            #region IndexOf

            // IndexOf Metodu: Dizideki elemanların indeksini bulur. 
            // Eğer eleman dizide yoksa -1 döner. Aramaya baştan başlar o nedenle aynı ögeden birden fazla varsa ilk bulduğunu döndürür.

            Console.WriteLine("Aramak istediğiniz şehri giriniz: ");
            string arananSehir = Console.ReadLine();
            int hangiIndex = Array.IndexOf(sehirler, arananSehir);
            Console.WriteLine(hangiIndex);

            int hangiIndex2 = Array.IndexOf(sehirler, arananSehir, hangiIndex + 1);
            Console.WriteLine(hangiIndex2);

            Console.WriteLine(hangiIndex2 < 2 ? "Aradığınız eleman listede tek " : "Aradığınız eleman listede tek değil");

            #endregion

            Console.WriteLine("\n" + new string('#', 20) + "\n");

            #region LastIndexOf

            // LastIndexOf Metodu: Dizideki elemanların son indeksini bulur.
            Console.Write("Aramak istediğiniz şehri giriniz: ");
            string arananSehirLast = Console.ReadLine();

            int hangiLastIndex = Array.LastIndexOf(sehirler, arananSehir);
            Console.WriteLine(hangiLastIndex);
            #endregion

            Console.WriteLine("\n" + new string('#', 20) + "\n");

            #region Reverse

            // Reverse Metodu: Dizinin elemanlarını ters çevirir.
            Array.Reverse(sehirler);
            foreach (string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            #endregion

            Console.WriteLine("\n" + new string('#', 20) + "\n");

            #region Copy

            // Copy Metodu: Dizinin elemanlarını kopyalar. İstenilen eleman sayısı kadar kopyalar.
            string[] yeniSehirler = new string[4];
            for (int i = 0; i < 4; i++)
            {
                yeniSehirler[i] = sehirler[i];
            }

            Array.Copy(sehirler, 3, yeniSehirler, 2, 2); // 3. indexten başlayarak 2 elemanı yeniSehirler dizisine kopyalar.

            foreach (var item in yeniSehirler)
            {
                Console.WriteLine(item);
            }

            #endregion

            Console.WriteLine("\n" + new string('#', 20) + "\n");

            #region Resize

            // Resize Metodu: Dizinin boyutunu değiştirir. Yeni boyutunu parametre olarak alır.
            Array.Resize(ref sehirler, 12); // sehirler dizisinin boyutunu 12 yapar.
            Console.WriteLine("Yeni Boyut: " + sehirler.Length);

            foreach (var item in sehirler)
            {
                Console.WriteLine(item);
            }
            #endregion

        }
    }
}
