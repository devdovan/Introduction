namespace _15_LABSayiTahmin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool devamMi = true;
            while (devamMi)
            {
                Random rnd = new Random();
                int tutulanSayi = rnd.Next(1, 10); // 1 ile 10 arasında rastgele bir sayı
                int tahminSayisi;

                Console.WriteLine("Sayı Tahmin Oyunu (1-10)");
                Console.WriteLine("Toplam Hakkınız 3");

                for (int i = 3; i > 0; i--)
                {
                    Console.WriteLine("Sayı Tahmin Ediniz: ");
                    tahminSayisi = int.Parse(Console.ReadLine());

                    if (tahminSayisi == tutulanSayi)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // Doğru tahmin için yeşil renk
                        Console.WriteLine("Tebrikler! Doğru tahmin ettiniz.");
                        i = 0; // Döngüyü sonlandır
                    }
                    else if (tahminSayisi > tutulanSayi)
                    {
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Red; // Yanlış tahmin için kırmızı renk
                        Console.WriteLine("Tahmininiz çok yüksek. Kalan hakkınız: {0} ", (i - 1));
                        Console.ResetColor(); // Renkleri sıfırla
                    }
                    else if (tahminSayisi < tutulanSayi)
                    {
                        Console.Beep();
                        Console.ForegroundColor = ConsoleColor.Yellow; // Yanlış tahmin için sarı renk
                        Console.WriteLine("Tahmininiz çok düşük. Kalan hakkınız: {0} ", (i - 1));
                        Console.ResetColor(); // Renkleri sıfırla
                    }

                }
                Console.ResetColor(); // Renkleri sıfırla
                Console.WriteLine("Oyunu bitirmek istiyor musunuz? [yes] [no]");
                devamMi = Console.ReadLine() == "yes" ? true : false;
            }
        }
    }
}
