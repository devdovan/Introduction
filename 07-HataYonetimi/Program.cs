using System.Reflection.Emit;

namespace _07_HataYonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * İSTİSNA TİPLERİ
             * Derleme Zamanı Hatası(Compile Time Error): Derleme aşamasında ortaya çıkan hatalardır. Bu tür hatalar genellikle yazım hataları (syntax) olarak karşımıza çıkar. Yönetmesi en kolay hata türüdür. Visual Studio anlık olarak bizlere yardımcı olur.
             * Çalışma Zamanı Hatası(Runtime Error): Program çalışırken ortaya çıkan hatalardır. Bu tür hatalar genellikle mantık hataları (logic) olarak karşımıza çıkar. Yüzde 90 kullanıcı odaklıdır. Programın akışını etkileyebilir. Try-Catch bloklarıyla yönetilebilir.
             * Mantıksal Hatalar(Logical Error):  Uygulamanın algoritmasından kaynaklıdır. Yüzde yüz yazılımcı kaynaklı hatalardır. Programın akışını etkilemeyen hatalardır. Program çalışır ama beklenilen sonucu vermez. Bu tür hatalar genellikle algoritma hatalarıdır.  Try-Catch bloklarıyla yönetilemez.
            */

            #region Ornek1
            int sayi1, sayi2, toplam;

            try
            {
                //Hata gelmesi muttemel olan kodlarımızı yazdığımız alan.
                Console.Write("Birinci sayıyı giriniz:");
                sayi1 = int.Parse(Console.ReadLine());

                Console.Write("İkinci sayıyı giriniz:");
                sayi2 = int.Parse(Console.ReadLine());

                toplam = sayi1 + sayi2;
                Console.WriteLine("Toplam: {0}", toplam);
            }
            catch
            {
                //Herhangi bir hata geldiğinde çalışacak olan kodlarımızı alan.
                Console.WriteLine("Rakamla sayıları giriniz!");
            }
            #endregion

            #region Ornek2
            try
            {
                Console.WriteLine("Telefon Numaranızı Giriniz: ");
                int telefon = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Tebrikler Kayıt İşlemi Başarılı...");
            }
            catch (Exception hata)
            {
                Console.WriteLine(hata.Message.ToString());
            }
        #endregion

            #region Ornek3

            Label1:
                try
                {
                    Console.WriteLine("Telefon Numaranızı Giriniz: ");
                    int telefonNo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Tebrikler Kayıt İşlemi Başarılı...");
                }
                catch (FormatException hata)
                {
                    //Dönüştürmeden Kaynaklı Uyumsuzlklarda Çalışacak olan kodlarımızı yazdığımız alan.
                    Console.WriteLine("Doğru Formatta Giriş Yapılmadı! Message {0}", hata.Message.ToString());
                    goto Label1;
                }
                catch (OverflowException hata)
                {
                    //Veri Tipinin Sınırlarını Aşan Değerlerde Çalışacak olan kodlarımızı yazdığımız alan.
                    Console.WriteLine("Veri Tipinin Sınırlarını Aşan Değer Girişi Yapıldı! Message {0}", hata.Message.ToString());
                }
                catch (Exception hata)
                {
                    //Diğer Hatalarda Çalışacak olan kodlarımızı yazdığımız alan.
                    Console.WriteLine("Beklenmeyen Bir Hata Gerçekleşti! Message {0}", hata.Message.ToString());
                }

                #endregion

            #region Ornek4
            try
            {
                Console.WriteLine("Telefon Numaranızı Giriniz: ");
                int telefonNo1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Tebrikler Kayıt İşlemi Başarılı...");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Message: {0}", ex.Message.ToString());
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Message: {0}", ex.Message.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Message: {0}", ex.Message.ToString());
            }
            finally
            {
                //Hata olsa da olmasa da çalışacak olan kodlarımızı yazdığımız alan.
                Console.WriteLine("Hata var mı yok mu bilmiyorum ama çalıştım...");
            }
            #endregion

            #region Ornek5

            //Try-Catch ve goto ifadelerini kullanarak kullanıcıdan iki sayı alınması ve bu sayılarla basit bir bölme işlemi yapılmasını sağlayan programı yazalım.
            int number1, number2, result;
        Basla1:
            try
            {
                Console.Write("Lütfen Brinci Sayıyı Giriniz: ");
                number1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Lütfen İkinci Sayıyı Giriniz: ");
                number2 = Convert.ToInt32(Console.ReadLine());

                result = number1 / number2;
                Console.WriteLine("Bölüm: {0}", result);

            }
            catch (FormatException hata1)
            {
                Console.WriteLine($"Tip Hatası - Message: {hata1.Message.ToString()}");
                goto Basla1;
            }
            catch (OverflowException hata2)
            {
                Console.WriteLine($"Boyut Hatası - Message: {hata2.Message.ToString()}");
                goto Basla1;
            }
            catch (DivideByZeroException hata3)
            {
                Console.WriteLine($" Sıfıra Bölme Hatası - Message: {hata3.Message.ToString()}");
                goto Basla1;
            }
            catch (Exception hata4)
            {
                Console.WriteLine($"Beklenmeyen Hata - Message: {hata4.Message.ToString()}");
                goto Basla1;
            }

            //Value Type and Reference Type
            //Stach Heap
            //Boxing and Unboxing
            //Compile Time and Run Time
            //Try-Catch

            #endregion



        }
    }
}
