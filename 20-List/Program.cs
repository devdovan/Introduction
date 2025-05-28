namespace _20_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> , genellikle dizilere benzer şekilde veri saklamak ve işlemek için kullanılan dinamik bir koleksiyon (Collection) türüdür.
            //List<T> sınıfı, System.Collections.Generic ad alanında bulunur ve T, listeye eklemek istediğiniz öğelerin türünü temsil eder.
            //List<T> sınıfı, öğeleri dinamik olarak ekleyip kaldırmanıza olanak tanır ve bu nedenle boyutu sabit olmayan koleksiyonlar için idealdir.

            //Dizinin Handikapları (BoyutZorunluluğu,Tip Zorunluluğu)
            //1. Boyut Sabitliği: Diziler, oluşturulduktan sonra boyutları değiştirilemez. Yani, bir dizi oluşturduğunuzda, o dizinin boyutu sabittir ve daha sonra öğe ekleyemezsiniz.
            //2. Performans: Diziler, bellekte ardışık olarak depolanır ve bu nedenle öğelere erişim hızı yüksektir. Ancak, öğe ekleme veya silme işlemleri, dizinin boyutunu değiştirmek için tüm öğeleri yeniden kopyalamayı gerektirebilir, bu da performansı olumsuz etkileyebilir.
            //3. Tür Güvenliği: Diziler, belirli bir türde öğeler içerebilir, ancak bu tür öğeleri değiştirmek veya farklı türde öğeler eklemek zor olabilir. Örneğin, bir int dizisine string eklemeye çalışmak derleme hatasına neden olur.

            List<string> sehirler = new List<string>() { "İstanbul", "Ankara", "İzmir" };
            sehirler.Add("Trabzon");
            sehirler.Add("Konya");
            sehirler.Add("Samsun");

            Console.WriteLine(sehirler[2]);

            foreach (string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }
            Console.WriteLine("Dizinin Boyutu: " + sehirler.Count);

            sehirler.Add("Rize");
            sehirler.Add("Bursa");
            sehirler.Add("Mersin");

            sehirler.Remove("Ankara");
            sehirler.RemoveAt(3); //İlk 3 elemanı siler
            Console.WriteLine("Silme yapıldı yeni boyut: " + sehirler.Count);

            Console.ReadLine();

            for (int i = 0; i < sehirler.Count; i++)
            {
                Console.WriteLine(sehirler[i]);
            }

            //List<T> elamanları dizilere benzer şekilde saklar ancak boyutu dinamik olarak büyütebilir ve küçültebilir. Dizelere göre daha esnek ve geniş kullanım imkanı sağlar. Ancak büyük koleksiyonlarda performans açısından dikattli kullanılması gerekebilir.

            List<int> numbers = new List<int>() { 10, 20 };
            numbers.Add(30);
            numbers.TrimExcess(); // Listeyi en son eklenen öğelere göre yeniden boyutlandırır, gereksiz bellek kullanımını önler.

            #region ReferenceType

            Console.WriteLine("\n" + new string('£', 20) + "\n");
            Console.WriteLine("Sayılar - 1\n");

            List<double> sayilar1 = new List<double>();
            sayilar1.Add(50);
            sayilar1.Add(44.9);
            sayilar1.Add(53.5);
            sayilar1.Add(34);

            foreach (double sayi in sayilar1)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("\n" + new string('£', 20) + "\n");
            Console.WriteLine("Sayılar - 2\n");

            List<double> sayilar2 = sayilar1; // sayilar1 referansını sayilar2'ye atar, yani her iki liste de aynı nesneyi referans alır.
            sayilar2.Add(12);
            sayilar2.Add(43);

            foreach (double sayi in sayilar2)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("\n" + new string('£', 20) + "\n");
            Console.WriteLine("Sayılar - 1\n");

            foreach (double sayi in sayilar1)
            {
                Console.WriteLine(sayi);
            }

            #endregion





        }
    }
}
