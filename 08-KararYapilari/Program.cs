namespace _08_KararYapilari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Program akışını kontrol etmek ve belirli koşullara göre işlem yapmak için karar yapıları kullanılır.
            //If Else
            //Ternary If
            //Switch Case

            #region If-Else
            //Mantıksal bir ifadenin sonucuna bağlı olarak iki farklı kod bloğundan sadece birinin çalıştırılmasını seçmek için if deyimi kullanılır.
            if (true)  //Mantıksal İfade veya Koşul 
            { //Scope Area

                //Koşul gerçekleşiyorsa çalışacak kod bloğu
            }
            else
            {

                //Koşul gerçekleşmiyorsa çalışacak kod bloğu
            }

            Console.Write("User Name: ");
            string userName = Console.ReadLine();

            if (userName == "admin") //Koşul gerçekleşiyor mu?
            {
                Console.WriteLine("Welcome Admin");
            }
            else if (userName == "guest")
            {
                Console.WriteLine("Welcome Guest");
            }
            else
            {
                Console.WriteLine("User not found");
            }

            //Karşılaştırma Operatörler
            /*
             1) == (Eşittir)
             2) != (Eşit Değildir.)
             3) < (Soldaki değerin Sağdaki değerden küçük olması durumu).
             4) > (Soldaki değerin Sağdaki değerden büyük olması durumu)
             5) <= (Soldaki değerin Sağdaki değerden eşit yada ondan küçük olması durumu)
             6) >= (Soldaki değerin Sağdaki değerden eşit yada ondan büyük olması durumu).
             */

            #endregion

            #region Ornek-1
            //Kullanıcıdan Not1 ve Not2 değerlerini alalım. Not ortalaması 50 den büyükse ekrana "Geçtiniz" yazsın 50 den küçükse "Kaldınız" yazsın.

            int not1, not2, ortalama;
            Console.Write("Not1: ");
            not1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Not2: ");
            not2 = Convert.ToInt32(Console.ReadLine());

            ortalama = (not1 + not2) / 2;

            if (ortalama >= 50)
            {
                Console.WriteLine($"Notunuz: {ortalama} Bu dersten geçtiniz");
            }
            else
            {
                Console.WriteLine($"Notunuz: {ortalama} Bu dersten kaldınız");
            }
            #endregion

            #region Ornek-2
            //Not 0 dan küçükse 0 dan küçük bir not girişi yapamazsınız. 100 den büyükse 100 den büyük bir not girişi yapamazsınız. 0-100 arasında ise doğru aralıkta değer girdiniz.
            Console.Write("Notunuzu Giriniz: ");
            int not = int.Parse(Console.ReadLine());

            if (not < 0)
            {
                Console.WriteLine("0 dan küçük bir not girişi yapamazsınız.");
            }
            else if (not > 100)
            {
                Console.WriteLine("100 den büyük bir not girişi yapamazsınız.");
            }
            else
            {
                Console.WriteLine("Doğru aralıkta değer girdiniz.");
            }

            #endregion

            #region Ornek-3
            //Bu şekilde iç içe kullanılıdığında mantıksal deyimler bibirlerine zincirlenir ve bir tanesi true değer dönünceye kadar birbiri arkasına çalıştırılır. Eğer hiçbir koşulumuz gerçekleşmezse else ifadesinin altındaki kod satırı çalışır.
            Console.WriteLine("Randevu almak için gün seçiniz. Pazartesi [1], Salı [2], Çarşamba [3], Perşembe [4], Cuma [5], Cumartesi [6], Pazar [7]");
            int gun = int.Parse(Console.ReadLine());
            if (gun == 1)
            {
                Console.WriteLine("Pazartesi günü randevu alabilirsiniz.");
            }
            else if (gun == 2)
            {
                Console.WriteLine("Salı günü randevu alabilirsiniz.");
            }
            else if (gun == 3)
            {
                Console.WriteLine("Çarşamba günü randevu alabilirsiniz.");
            }
            else if (gun == 4)
            {
                Console.WriteLine("Perşembe günü randevu alabilirsiniz.");
            }
            else if (gun == 5)
            {
                Console.WriteLine("Cuma günü randevu alabilirsiniz.");
            }
            else if (gun == 6)
            {
                Console.WriteLine("Cumartesi günü randevu alabilirsiniz.");
            }
            else if (gun == 7)
            {
                Console.WriteLine("Pazar günü randevu alabilirsiniz.");
            }
            else
                Console.WriteLine("Geçersiz gün seçtiniz.");

            Console.WriteLine("Program yükleniyor...");

            #endregion

            #region Ornek-4
            //Kullanıcıdan alınan sayının tek mi çift mi olduğunu kontrol edelim.
            Console.Write("Bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Sayı tektir.");
            }

            //Kullanıcıdan alınan sayının sıfır mı pozitif mi negatif mi olduğunu kontrol edelim.

            Console.Write("Bir sayı giriniz: ");
            int girilenSayi = int.Parse(Console.ReadLine());
            if (girilenSayi > 0)
            {
                Console.WriteLine($"{girilenSayi} Pozitif sayı giridiniz.");
            }
            else if (girilenSayi < 0)
            {
                Console.WriteLine($"{girilenSayi} Negatif sayı girdiniz.");
            }
            else
            {
                Console.WriteLine($"{girilenSayi} Sıfır girdiniz.");
            }
            #endregion

            #region Ornek-5
            //Kapı Kullanımı
            //AND && : Her iki koşulun da doğru olması durumunda true döner.
            //OR || : Her iki koşuldan en az birinin doğru olması durumunda true döner.

            //Dip Not
            //AND (VE) &&: Koşulun bir tarafını kontrol eder olumsuz ise diğer tarafı kontrole etmez.

            Console.WriteLine("Kullanıcı Adı: ");
            string kullaniciAdi = Console.ReadLine();

            Console.WriteLine("Kullanıcı Şifre: ");
            string kullaniciSifre = Console.ReadLine();

            if (kullaniciAdi == "admin" && kullaniciSifre == "1234")
            {
                Console.WriteLine("Tebrikler, tum bilgiler dogru. Hoş geldiniz.");
            }
            else
            {
                Console.WriteLine("Üzgünüm. Kullanıcı Adı veya Şifre hatalı.");
            }

            Console.WriteLine(new string('*', 20));

            if (kullaniciAdi == "admin")
            {
                if (kullaniciSifre == "1234")
                {
                    Console.WriteLine("Tebrikler, tum bilgiler dogru. Hoş geldiniz.");
                }
                else
                {
                    Console.WriteLine("Üzgünüm. Kullanıcı Adı veya Şifre hatalı.");
                }

            }
            else
            {
                Console.WriteLine("Kullanıcı Adı yanlış. Şifre yanlış mı bilmiyorum.");
            }
            #endregion

            #region Ornek-6
            //Dışarıdan ürün adı girilecek, uygulama bize hangi bölümde olduğunu söylecek.
            //Domates,salatalık biber, patlıcan => Sebze bölümüne bakınız.
            //Diş macunu, parfüm, şampuan => Kozmetik bölümü
            //telefon, tablet, pc => teknoloji bölümü
            //başka bir ürün girerse => aradığınız ürün bizde yok.

            Console.WriteLine("Ürün adı giriniz: ");
            string product = Console.ReadLine();
            if (product == "domates" || product == "salatalık" || product == "biber" || product == "patlıcan")
            {
                Console.WriteLine("Sebze bölümüne bakınız. Kat-1");
            }
            else if (product == "diş macunu" || product == "parfüm" || product == "şampuan")
            {
                Console.WriteLine("Kozmetik bölümüne bakınız. Kat-2");
            }
            else if (product == "telefon" || product == "tablet" || product == "pc")
            {
                Console.WriteLine("Teknoloji bölümüne bakınız. Kat-3");
            }
            else
            {
                Console.WriteLine("Aradığınız ürün bizde yok.");
            }

            #endregion

            #region Ornek-7

            //Kullanıcıdan Vize ve Final Notunu isteyecekseniz (Vizenin yüzde 30) (Finalin yüzde 70) alarak ortalama notu bulacaksınız. Ortalama not 0-15 FF 16-30 DD 31-50 CC 51-70 BB 71-100 AA
            double vizeNot, finalNot, ortalamaNot;
            Console.Write("Vize Notu: ");
            vizeNot = Convert.ToDouble(Console.ReadLine());
            Console.Write("Final Notu: ");
            finalNot = Convert.ToDouble(Console.ReadLine());
            ortalamaNot = (vizeNot * 0.30) + (finalNot * 0.70);

            if (ortalamaNot >= 0 && ortalamaNot < 16)
            {
                Console.WriteLine($"Ortalama Not: {ortalamaNot} - FF");
            }
            else if (ortalamaNot >= 16 && ortalamaNot < 31)
            {
                Console.WriteLine($"Ortalama Not: {ortalamaNot} - DD");
            }
            else if (ortalamaNot >= 31 && ortalamaNot < 51)
            {
                Console.WriteLine($"Ortalama Not: {ortalamaNot} - CC");
            }
            else if (ortalamaNot >= 51 && ortalamaNot < 71)
            {
                Console.WriteLine($"Ortalama Not: {ortalamaNot} - BB");
            }
            else if (ortalamaNot >= 71 && ortalamaNot <= 100)
            {
                Console.WriteLine($"Ortalama Not: {ortalamaNot} - AA");
            }
            else
            {
                Console.WriteLine("Geçersiz not aralığı.");
            }
            #endregion
        }
    }
}
