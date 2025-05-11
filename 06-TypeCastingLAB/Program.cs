namespace _06_TypeCastingLAB
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region Ornek1
            //Dışarıdan alınan iki sayının toplamıyla farkının birbirine bölümünden kalan kaçtır?

            Console.Write("Lütfen birinci sayıyı giriniz: ");
            int donusenSayi1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Lütfen ikinci sayıyı giriniz: ");
            int donusenSayi2 = Convert.ToInt32(Console.ReadLine());

            int toplam = donusenSayi1 + donusenSayi2;
            int fark = donusenSayi1 - donusenSayi2;
            int kalan = toplam % fark;

            Console.WriteLine("Sonuç: {0}", kalan);
            #endregion

            #region Ornek2  
            //Dışarıdan girilen bir sayının 10 eksiğinin 20 fazlasının 2 bölümünden kalanın karesi kaçtır?

            Console.WriteLine("Bir sayı giriniz: ");
            int islem = Convert.ToInt32(Console.ReadLine());
            islem = (islem - 10 + 20) % 2;
            Console.WriteLine($"Sonuç: {islem *= islem}");
            #endregion

            #region Ornek3
            //Muz fiyatı kullanıcıdan dolar cinsinden alınsın. (dolar 38.71) bana TL cinsinden ekrana yazdırılsın. Kdv li fiyatıda yazılsın (Yüzde 20)

            double fiyat, dolar = 38.71, kdv = 1.20;

            Console.WriteLine("Muz fiyatını dolar cinsinden giriniz: ");
            fiyat = Convert.ToDouble(Console.ReadLine());

            double tlFiyat = fiyat * dolar;
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Muzun TL fiyatı: {tlFiyat} TL");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"Muzun KDV'li fiyatı: {tlFiyat * kdv} TL");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;


            #endregion
        }
    }
}
