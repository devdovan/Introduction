namespace _09_KararYapılarıTernaryIf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TernaryIf
            //If ifadesinin daha basit ve kısa sözdizimine sahip kullanım şeklidir.
            //Ternary if, üçlü operatör olarak da bilinir.
            //Ternary if, bir koşulun doğru veya yanlış olmasına göre iki farklı değer döndürür.
            //Tek satırda ufak bir karar mekanizması ile yolumuza devam etmek için kullanılır. Genenllikle bir koşulun sonuca bağlı olarak bir değişkene değer atamak için kullanılır.

            int sayi = 3 > 2 ? 10 : 20;

            //Ornek-1
            int sayi1 = -10;
            string sonuc1;
            if (sayi1 > 0)
            {
                sonuc1 = "Pozitif";
            }
            else
            {
                sonuc1 = "Negatif";
            }
            Console.WriteLine(sonuc1);

            //Kısa Sözdizimi
            int sayi2 = 10;
            string sonuc2 = sayi2 > 0 ? "Pozitif" : "Negatif";

            //Ornek-2
            Console.WriteLine("Kullanıcı Adı: ");
            string userName = Console.ReadLine();

            if (userName == "admin")
            {
                Console.WriteLine("Hoşgeldin Admin");
            }
            else
            {
                Console.WriteLine("Hoşgeldin " + userName);
            }

            //Kısa Sözdizimi
            Console.WriteLine(userName == "admin" ? "Hoşgeldiniz" : "Hatalı Giriş");

            #endregion

            #region LAB
            //Disaridan siparis alinacak olan kitap miktari girilsin. Sipari sayisi 20'den azsa toplam ucretten %5, 20 - 50 araliginda ise %10, 50-100 araligi ise %15, 100'den fazla ise %25 indirim yapilsin. Kitabın birim fiyatı => 50 TLdir... Amac => Odenecek tutari kullaniciya gostermek...

            //Toplam Fiyat: 3500
            //Indirim Miktarı: 500
            //Indırım Fiyat: 3000 TL (Kırmızı)
            //Kdv: %10
            //Kdvli Toplam Fiyat: 3300 TL (Yesil)

            Console.Title = "Dovan Muhasebe Programı";

            double toplamFiyat,
                indirimMiktari,
                indirimliFiyat,
                kdvliFiyat;
            const double birimFiyat = 50, kdv = 1.10;
            int siparisSayisi;
            bool devamMi = true;

            Console.WriteLine("\n" + new string('*', 10) + " Muhasabe Programı " + new string('*', 10) + "\n");

            while (devamMi)
            {
                Console.WriteLine("Kitap Adedi Giriniz: ");
                //Dönüşüm Bilgisi(True/False) = (Dönüştürülecek Değer, out Dönüşüm Sonucu)
                bool donusumSonucu = int.TryParse(Console.ReadLine(), out siparisSayisi);

                if (donusumSonucu && siparisSayisi > 0)
                {
                    //Burada İşlemler Yapılacak
                    toplamFiyat = siparisSayisi * birimFiyat;

                    if (siparisSayisi < 0 && siparisSayisi <= 20)

                        indirimMiktari = toplamFiyat * 0.05;

                    else if (siparisSayisi > 20 && siparisSayisi <= 50)

                        indirimMiktari = toplamFiyat * 0.10;

                    else if (siparisSayisi > 50 && siparisSayisi <= 100)

                        indirimMiktari = toplamFiyat * 0.15;

                    else

                        indirimMiktari = toplamFiyat * 0.25;

                    indirimliFiyat = toplamFiyat - indirimMiktari;
                    kdvliFiyat = indirimliFiyat * kdv;
                    Console.WriteLine($"Sipariş Adeti: {siparisSayisi} X Birim Fiyatı: {birimFiyat} = {toplamFiyat} TL.");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Müşteriye Özel İndirim");
                    Console.WriteLine($"İndirim Miktari: {indirimMiktari}");
                    Console.WriteLine($"İndirim'li Toplam Fiyat: {indirimliFiyat} TL.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(new string('-', 20));
                    Console.WriteLine($"Ödeme Miktarı (KDV Dahil): {kdvliFiyat} TL.");

                    Console.Write("\nDevam etmek istiyor musun? [yes] [no]: ");

                    devamMi = Console.ReadLine() == "yes" ? true : false;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Beep();
                    Console.WriteLine("Üzgünüm hatalı bir giriş yaptınız.");
                    Console.ForegroundColor = ConsoleColor.White;
                    devamMi = false;
                }


            }




            #endregion
        }
    }
}
