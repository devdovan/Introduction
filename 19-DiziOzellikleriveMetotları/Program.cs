namespace _19_DiziOzellikleriveMetotları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi Properties(Özellikler) and Methods(Metotlar)

            string[] sehirler = { "İstanbul", "Ankara", "İzmir", "Bursa", "Trabzon", "Eskisehir", "Konya", "Sivas", "Eskisehir" };
            // Length Özelliği: Dizinin eleman sayısını(boyutunu) verir.
            Console.WriteLine($"Dizinin Boyutu: {sehirler.Length}");
            foreach (string sehir in sehirler)
            {
                Console.WriteLine(sehir);
            }

            Console.WriteLine("\n");
        }
    }
}
