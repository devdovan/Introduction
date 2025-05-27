namespace _14_LABHesapMakinesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uygulama Biilgilendirme

            Console.WriteLine("Basit Bir C# Hesap Makinesi Uygulamasına Hoş Geldiniz!");
            Console.WriteLine("İşlem: [+ | - | * | / ] - Çıkış için boş geçiniz.");

            //Değişkenleri Tanımlama
            double firstNumber, secondNumber = 0, result = 0;
            string mathOperation = "+";
            while (mathOperation != string.Empty)
            {
                try
                {
                    Console.Write("İşlem: ");
                    mathOperation = Console.ReadLine();

                    Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
                    firstNumber = Convert.ToDouble(Console.ReadLine());

                    Console.Write("{0} , {1}", firstNumber, mathOperation);

                    Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
                    secondNumber = Convert.ToDouble(Console.ReadLine());

                }
                catch
                {
                    Console.WriteLine("Hatalı bir işlem gerçekleşti.");
                    Console.WriteLine("Devam etmek istiyor musunuz? [yes] [no]");
                    string status = Console.ReadLine();
                    if ((status != "yes"))
                        mathOperation = string.Empty;
                    continue; // Hatalı girişte döngünün başına dön

                }
                switch (mathOperation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        Console.WriteLine("Toplamı: {0} ", result);
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        Console.WriteLine("Fark: {0}", result);
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        Console.WriteLine("Çarpım: {0} ", result);
                        break;
                    case "/":
                        if (secondNumber != 0)
                        {
                            result = firstNumber / secondNumber;
                            Console.WriteLine("Bölüm: {0}", result);
                        }
                        else
                        {
                            Console.WriteLine("Sıfıra bölme hatası!");
                        }
                        break;
                    default:
                        Console.WriteLine("Geçersiz işlem. Lütfen [+ | - | * | /] kullanın.");
                        break;
                }

                firstNumber = result; // Sonucu birinci sayıya atayarak devam et

            }
            Console.WriteLine("Program kapandı...");



        }
    }
}
