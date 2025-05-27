namespace _13_DongulerDoWhileDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string durum = "yes";
            do
            {
                Console.WriteLine("Döngünün içindesin.");
                Console.WriteLine("Devam etmek istiyor musun? [yes] [no] :");
                durum = Console.ReadLine();
            } while (durum != "no");

            string kullaniciAdi = "";
            string kullaniciSifre = "";

            do
            {
                Console.WriteLine("Kullanıcı adnı giriniz: ");
                kullaniciAdi = Console.ReadLine();
                Console.WriteLine("Kullanıcı şifresini giriniz: ");
                kullaniciSifre = Console.ReadLine();

            } while (kullaniciAdi != "admin" && kullaniciSifre != "1234");
            Console.WriteLine("Giriş başarılı! Hoş geldiniz " + kullaniciAdi + "!");
            Console.WriteLine("Program sonlandı. Çıkmak için bir tuşa basın.");

            Console.ReadKey();
            //Özetle do-while döngüsü, koşul sağlanmasa bile en az bir kez çalışır.



        }
    }
}
