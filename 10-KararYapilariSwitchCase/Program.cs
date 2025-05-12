namespace _10_KararYapilariSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Switch Case Yapısı
            //Switch Case ile yapılabilen kontorlerinin hepsini if-else ile de yapabiliriz. Aradaki fark ise if-else büyük-küçüklük gibi durumlarıda kontrol edebiliyorken.
            //***Switch Case yapısı yalnızca eşitlik durumlarını kontrol eder.

            Console.WriteLine("1 [C#], 2 [VB],3 [JAVA], 4 [C]");
            Console.WriteLine("Lütfen bir dil seçiniz: ");

            int dil = Convert.ToInt32(Console.ReadLine());
            //Switch Case yapısı
            switch (dil)
            {
                case 1:
                    Console.WriteLine("C# dilini seçtiniz.");
                    break;
                case 2:
                    Console.WriteLine("VB dilini seçtiniz.");
                    break;
                case 3:
                    Console.WriteLine("JAVA dilini seçtiniz.");
                    break;
                case 4:
                    Console.WriteLine("C dilini seçtiniz.");
                    break;
                default:
                    Console.WriteLine("Senin seçimin...");
                    break;
            }

            Console.WriteLine("Mevsim Seçiniz: 1 [Kış], 2 [İlkbahar],3 [Yaz], 4 [Sonbahar]");
            string mevsim = Console.ReadLine();

            switch (mevsim)
            {
                case "Kış":
                    Console.WriteLine("Aralık - Ocak - Şubat");
                    break;
                case "İlkbahar":
                    Console.WriteLine("Mart - Nisan - Mayıs");
                    break;
                case "Yaz":
                    Console.WriteLine("Haziran - Temmuz - Ağustos");
                    break;
                case "Sonbahar":
                    Console.WriteLine("Eylül - Ekim - Kasım");
                    break;
                default:
                    break;
            }

            Console.WriteLine("Lütfen Notunuzu Giriniz: A | B | C | D | F");
            string not = Console.ReadLine();

            //Switch Case yapısında birden fazla case bir arada kullanılabilir.
            switch (not)
            {
                case "A":
                case "B":
                case "C":
                    Console.WriteLine("Geçtiniz...");
                    break;
                case "D":
                    Console.WriteLine("Ortalama ile geçtiniz...");
                    break;
                case "F":
                    Console.WriteLine("Kaldınız...");
                    break;
                default:
                    Console.WriteLine("Hata");
                    break;

            }
           


        }
    }
}
