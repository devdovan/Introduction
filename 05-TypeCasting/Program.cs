namespace _05_TypeCasting
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Tip Dönüşümü (Type Casting): bir veri tipinden başka bir veri tipine değerleri dönüştürme.
            //İki Farklı tip dönüşümü vardır.
            // 1. Implicit Conversion (Bilinçsiz Dönüşüm): Küçük veri tipinden büyük veri tipine dönüşüm.
            // 2. Explicit Conversion (Bilinçli Dönüşüm): Büyük veri tipinden küçük veri tipine dönüşüm.
            /*
             * Ek Açıklama:
             1. Convert Class: Veri tiplerini dönüştürmek için kullanılan bir sınıftır.
             2. Parse Method: String veri tipini diğer veri tiplerine dönüştürmek için kullanılır.
             3. TryParse Method: String veri tipini diğer veri tiplerine dönüştürmek için kullanılır. Dönüşüm başarılı ise true, başarısız ise false döner.
             4. Boxing: Değer tipinin referans tipine dönüştürülmesi.
             5. Unboxing: Referans tipinin değer tipine dönüştürülmesi.
             6. Nullable Types: Değer tiplerinin null değer alabilmesi için kullanılır.
             7. Dynamic Types: Derleme zamanında belirlenmeyen veri tipidir. Çalışma zamanında belirlenir.
             8. var: Derleyici tarafından otomatik olarak belirlenen veri tipidir. Değer atandığında belirlenir.
             9. object: Tüm veri tiplerinin temel sınıfıdır. Her veri tipi object türünden türetilmiştir.
            */
            #region Implict (Bilinçsiz Dönüşüm)
            short degisken1 = 23456;
            int degisken2 = degisken1; // short -> int

            Console.WriteLine("Short değişkeni: {0}, Int değişkeni {1}", degisken1, degisken2);

            #endregion

            #region Explicit (Bilinçli Dönüşüm)
            int degisken3 = 231231231; //2.1
            short degisken4 = (short)degisken3; // int -> short 30000
            //Console.WriteLine("Short değişkeni: {0}, Int değişkeni {1}", degisken4, degisken3); // Hata verir.
            Console.WriteLine("Short değişkeni: {0}, Int değişkeni {1}", degisken4, degisken3);

            #endregion

            #region ConvertClass
            // Convert Class
            // Convert Sınıfı, .NET Framework'te bulunan farklı türler arasında dönüşümleri gerçekleştirmek için kullanılan bir sınıftır.
            // Convert sınıfı, temel veri türleri arasında dönüşüm yapabilir. Örneğin, int'i string'e, string'i int'e dönüştürebiliriz.
            string sayi = "123";
            int cevrilmisBir = Convert.ToInt32(sayi); // string -> int
            int cevrilmisIki = Convert.ToByte(sayi); // string -> byte
            int cevrilmisUc = Convert.ToInt16(sayi); // string -> short
            long cevrilmisDort = Convert.ToInt64(sayi); // string -> long
            float cevrilmisBes = Convert.ToSingle(sayi); // string -> float
            double cevrilmisAlti = Convert.ToDouble(sayi); // string -> double

            bool sonuc = true;
            //Console.WriteLine(Convert.ToInt32("metin")); 
            //=> System.FormatException: 'Input string was not in a correct format.'

            char karakter = 'A';
            Console.WriteLine(Convert.ToInt32(karakter)); // A -> 65

            int karakterA = 65;
            Console.WriteLine(Convert.ToChar(karakterA)); // 65 -> A

            #endregion

            #region ParseMethod

            // Parse Method
            // Parse metodu, sadece string veri tipini belirli bir veri tipine dönüştürmek için kullanılır.
            // Parse metodunun avantajı hızlı ve kolay bir şekilde uygulanmasıdır.

            string sayiDizi= "123";
            int sayi1;
            double ondalik;

            sayi1 = int.Parse(sayiDizi); // string -> int
            int oku=int.Parse(Console.ReadLine()); // string -> int
            int age = int.Parse("29"); // string -> int

            ondalik=double.Parse(sayiDizi); // string -> double
            double pi= double.Parse("3.14"); // string -> double

            bool dogruMu = bool.Parse("True"); // string -> bool

            #endregion

            #region  ToString()
            // ToString() metodu, bir nesneyi string veri tipine dönüştürmek için kullanılır.
            // ToString() metodu, tüm veri tiplerinde bulunur. Her veri tipi için farklı bir implementasyonu vardır.
            // Örneğin, int veri tipi için ToString() metodu, int değerini string'e dönüştürür.
            double vizeNot = 70.5;
            string not1 = vizeNot.ToString(); // double -> string
            string sayi2 = 123.ToString(); // int -> string
            #endregion






        }
    }
}
