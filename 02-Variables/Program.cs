using System.Text;

namespace _02_Variables
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region VariablesInformation
            //Değişkenler
            /*
             C# dilinde değişkenler, verileri saklamak için kullanılan isimlendirilmiş bellek alanlarıdır.
             */
            int a = 5;
            int b = 3;
            int c = a + b;
            Console.WriteLine(c);
            // Değişken Tanımlama

            // Değişken tanımlarken, veri türünü ve değişken adını belirtmemiz gerekir.
            // Örnek:veri_tipi değişken_adı = değer;
            //veri_tipi:Değişkenin saklayacağı veri türünü belirtir.
            //değişken_adı:Taşıyacağınız veriye erişim sağlamak için kullandığınız isimdir.

            //Değişken Tanımlamada Dikkat Edilmesi Gerekenler
            /*
             * Tanımlama yaparken büyük-küçük harf duyarlılığına dikkat edilmelidir.
             * Değişken adı rakamla başlayamaz. Rakamla bitebilir.
             * Teknik isimler için kullanılan anahtar kelimeler değişken adı olarak kullanılamaz.
             * Özel karakterler kullanılamaz. (Örnek: @, #, $, %, ^, &, *, (, ), !, ?, /, \, {, }, [, ], <, >) İstisna: ( _ ) kullanılabilir.
             * Boşluk kullanılamaz. (Örnek: "değişken adı" şeklinde tanımlanamaz.)
             * Türkçe karakter kullanılmamalıdır. (Örnek: "ş, ç, ğ, ü, ö, ı" gibi karakterler kullanılmamalıdır.)
             * camelCase: Değişken adı küçük harfle başlar ve her kelimenin ilk harfi büyük yazılır. (Örnek: "değişkenAdı" şeklinde tanımlanır.)
             * camelCase kullanmayarak asla değişken adı tanımlamayın. (Örnek: "DeğişkenAdı" şeklinde tanımlanamaz.) 
             */

            //Temel Veri Türleri
            //Sayısal Veri Türleri

            //Min: -128 Max: 127 -8 bit
            sbyte degiskenBir = 127;

            //Min:0 Max: 255 -8 bit
            byte degiskenIki = 255;

            //Min: -32768 Max: 32767 -16 bit
            short degiskenUc = -23456;

            //Min: 0 Max: 65535 -16 bit
            ushort degiskenDort = 12312;

            //Int: Min: -2147483648 Max: 2147483647 -32 bit
            int degiskenBes = -12321312;
            Int32 degiskenAltı = 12312312;

            //UInt: Min: 0 Max: 4294967295 -32 bit
            uint degiskenYedi = 1231231212;

            //Long: Min: -9223372036854775808 Max: 9223372036854775807 -64 bit
            long degiskenSekiz = -21312321312213;

            //ULong: Min: 0 Max: 18446744073709551615 -64 bit
            ulong degiskenDokuz = 12312312312312312311;

            //Ondalık Sayısal Veri Türleri
            //.dan sonra 7 basamak destekleyebilir. 32 bit
            float ondalikSayi1 = 2.121F;

            //double: .dan sonra 13 basamak destekleyebilir. 64 bit
            double ondalikSayi2 = 2.12312321;

            //decimal: .dan sonra 27 basamak destekleyebilir. 128 bit
            decimal ondalikSayi3 = 2.1232m;

            //Metinsel Veri Türleri

            //Karakter veri türü.
            char basHarfim = 'B';

            //String veri türü.
            string metin = "Buraya istediğiniz yazıyı yazabilirsiniz. \n" +
                "Bu birden fazla satırda yazılmış bir metin.\n" +
                "Bu metin içerisinde \t tab boşluğu bulunmaktadır.\n" +
                "Bu metin içerisinde \\ ters eğik çizgi bulunmaktadır.\n" +
                "Bu metin içerisinde \" çift tırnak bulunmaktadır.\n" +
                "Bu metin içerisinde \' tek tırnak bulunmaktadır.\n" +
                "Bu metin içerisinde \a alarm sesi bulunmaktadır.\n" +
                "Bu metin içerisinde \b geri silme bulunmaktadır.\n" +
                "Bu metin içerisinde \f yeni sayfa bulunmaktadır.\n" +
                "Bu metin içerisinde \r satır başı bulunmaktadır.\n" +
                "Bu metin içerisinde \v dikey sekme bulunmaktadır.\n" +
                "Bu metin içerisinde \0 null karakter bulunmaktadır.\n";

            Console.WriteLine(metin);

            //Mantıksal Veri Türleri
            //bool: true veya false değerlerini alabilir. 1 bit
            bool bugunTatilMi = true;
            bool yeniKayitVarMi = false;
            bool buyukMu = 10 > 2;

            #endregion

            //Operators (Operatörler) Sum (Toplama), Subtract (Çıkarma), Multiply (Çarpma), Divide (Bölme), Modulus (Mod Alma), Increment (Artırma), Decrement (Azaltma)
            //Operatörler, değişkenler üzerinde işlem yapmamızı sağlar. Operatörler, iki veya daha fazla değişkeni bir araya getirerek yeni bir değer oluşturur.

            #region Ornek-1

            string adi, soyadi;
            Console.WriteLine("Adınızı giriniz: ");
            adi = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz: ");
            soyadi = Console.ReadLine();
            Console.WriteLine("Adınız: " + adi);
            Console.WriteLine("Soyadınız: " + soyadi);
            #endregion

            #region Ornek-2
            int sayi1 = 10, sayi2 = 20;
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);

            #endregion

            #region Ornek-3
            int yas = 29;
            int yıl = 2025;
            int dogumYili = yıl - yas;
            Console.WriteLine("Doğum Yılı: " + dogumYili);
            #endregion

            #region Ornek-4
            string ad = "Büşra";
            string soyad = "Dovan";
            string tamAd = ad + " " + soyad;
            Console.WriteLine(tamAd);

            #endregion

            #region Ornek-5
            double toplamPara = 100;
            double kisiSayisi = 3;
            double kisiBasinaPara = toplamPara / kisiSayisi;

            Console.WriteLine("Kişi Başına Para: " + kisiBasinaPara);
            #endregion

            #region Ornek-6
            bool gectiMi = true;
            Console.Write("Sınavdan Geçti Mi?");
            Console.WriteLine(gectiMi);
            #endregion

            #region Ornek-7
            //(+) Birleştirme Operatörü

            string name = "Büşra";
            int age = 27;

            //Birleştirme Operatörü
            Console.WriteLine("Benim adım: " + name + "dır. Yaşım: " + (age + 2) + "dir");

            //PlaceHolder (Yer Tutucu) Kullanımı
            Console.WriteLine("Benim adım: {0} dır. Yaşım: {1} dir. ", name, age + 2);

            //String Interpolation (Dize İçinde Değişken Kullanımı)
            Console.WriteLine($"Benim adım: {name} dır. Yaşım: {age + 2} dir");

            //String.Format() Kullanımı
            Console.WriteLine(string.Format("Benim adım: {0} dır. Yaşım: {1} dir. ", name, age + 2));
            //String.Concat() Kullanımı  
            Console.WriteLine(string.Concat("Benim adım: ", name, " dır. Yaşım: ", age + 2, " dir"));
            //String.Join() Kullanımı
            string[] kelimeler = { "Benim", "adım:", name, "dır.", "Yaşım:", (age + 2).ToString(), "dir." };
            Console.WriteLine(string.Join(" ", kelimeler));
            //StringBuilder Kullanımı
            StringBuilder sb = new StringBuilder();
            sb.Append("Benim adım: ");
            sb.Append(name);
            sb.Append(" dır. Yaşım: ");
            sb.Append(age + 2);
            sb.Append(" dir.");
            Console.WriteLine(sb.ToString());
            //StringBuilder Kullanımı (Daha Performanslı)
            StringBuilder sb2 = new StringBuilder();
            sb2.AppendFormat("Benim adım: {0} dır. Yaşım: {1} dir.", name, age + 2);
            Console.WriteLine(sb2.ToString());
            //Escape Sequences
            Console.WriteLine("\t Merhaba Dünya \n Bilge Adam \t Yazılım Eğitimi \\ Hocamızdan notlar \"Console.Writeline('Ders Bitti)\"");

            #endregion

            #region Ornek-8
            //İki tam sayı tanımlanacak üçüncü bir  değişken kullanlmadan yer değiştirme işlemi yapılacak.
            int k = 3;
            int l = 5;

            Console.WriteLine("İşlem öncesi X: {0} ve Y: {1}", k, l);

            //Yer değiştirme işlemi
            k = k + l;
            l = k - l;
            k = k - l;

            Console.WriteLine("İşlem sonrası X: {0} ve Y: {1}", k, l);

            #endregion

            #region Ornek-9
            int x = 2, y = 5, z = 1;

            if (x < y)
            {
                x = x + y;
                y = x - y;
                x = x - y;
            }

            if (y < z)
            {
                y = y + z;
                z = y - z;
                y = y - z;
            }

            if (x < z)
            {
                x = x + z;
                z = x - z;
                x = x - z;
            }

            Console.WriteLine($"X: {x}, Y: {y}, Z: {z}");
            #endregion




        }
    }
}
