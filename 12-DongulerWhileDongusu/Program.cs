namespace _12_DongulerWhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region While
            //Mantıksal bir ifade gerçekleştiği sürece belirli bir kod bloğu çalıştırmak için kullanılır.

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int a = 1;
            //While (Koşul true ise)
            while (a < 10)
            {
                //Çalıştırılacak kod bloğu
                Console.WriteLine(a);
                a++;
            }

            string durum = "yes";

            //While (Koşul true ise)
            while (durum == "yes")
            {
                Console.WriteLine("Döngünün içindesin");
                Console.WriteLine("Devam etmek istiyor musunuz? [yes]/[no]");
                durum = Console.ReadLine();

                if (durum == "no")
                {
                    Console.WriteLine("Program sonlandırılıyor.");
                }
                else if (durum != "yes")
                {
                    Console.WriteLine("Geçersiz giriş. Lütfen 'yes' veya 'no' girin.");
                }
            }
            Console.WriteLine("Döngünün Dışındasın");
            #endregion

            #region Ornek
            bool devamMi = true;
            while (devamMi)
            {
                Console.Write("Kullanıcı Adı: ");
                string kullaniciAdi = Console.ReadLine();

                Console.Write("Kullanıcı Şifre: ");
                string kullaniciSifre = Console.ReadLine();

                if (kullaniciAdi == "admin" && kullaniciSifre == "1234")
                {
                    Console.WriteLine("Giriş başarılı!");
                    devamMi = false; // Döngüyü sonlandır
                }
                else
                {
                    Console.WriteLine("Kullanıcı adı veya şifre yanlış. Tekrar deneyin.");
                    Console.WriteLine("Çıkmak için 'q' tuşuna basın, devam etmek için herhangi bir tuşa basın.");
                    string cevap = Console.ReadLine();
                    if (cevap.ToLower() == "q")
                    {
                        devamMi = false; // Döngüyü sonlandır
                    }
                }
            }
            #endregion
        }
    }
}
