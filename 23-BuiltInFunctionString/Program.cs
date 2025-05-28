namespace _23_BuiltInFunctionString
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string ornekMetin;
            Console.WriteLine("Lütfen Bir Metin Giriniz: ");
            #region CompareTo

            //Metodu kullandığınız string değerle metoda parametre olarak verilen değeri sözlük mantığıyla karşılaştırır. Eğer sözlükte aynı lokasyonda yer alıyorsa 0, önceyese -1 sonra ise 1 döndürür.
            ornekMetin = Console.ReadLine();
            int sonuc = ornekMetin.CompareTo("BilgeAdam");
            switch (sonuc)
            {
                case 0:
                    Console.WriteLine("Metinler Eşit");
                    break;
                case -1:
                    Console.WriteLine("Metin BilgeAdam'dan Önce Geliyor");
                    break;
                case 1:
                    Console.WriteLine("Metin BilgeAdam'dan Sonra Geliyor");
                    break;
                default:
                    break;
            }
            #endregion

            #region Contains
            //İçermek
            //Metodun parametresinde verilen değerin string içerisinde geçip geçmediğini kontrol eder. Eğer geçiyorsa true, geçmiyorsa false döndürür.
            ornekMetin = Console.ReadLine();
            bool varMi = ornekMetin.Contains("adam");
            Console.WriteLine("Aradığınız Değer" + (varMi ? "bulunmaktadır" : "bulunmamaktadır"));
            #endregion

            #region Startswith
            //Başlamak
            //Metodun parametresinde verilen değerin string'in başında olup olmadığını kontrol eder. Eğer başında ise true, değilse false döndürür.
            ornekMetin = Console.ReadLine();
            bool basliyorMu = ornekMetin.StartsWith("Bilge");
            Console.WriteLine(basliyorMu ? "Kelime Bilge ile başlıyor" : "Kelime Bilge ile başlamıyor");
            #endregion

            #region EndsWith

            //Bitiş
            //Metodun parametresinde verilen değerin string'in sonunda olup olmadığını kontrol eder. Eğer sonunda ise true, değilse false döndürür.
            ornekMetin = "BilgeAdam Yazılım ve Bilişim Akademisi";
            bool bitiyorMu = ornekMetin.EndsWith("Kadın");
            Console.WriteLine(bitiyorMu);
            #endregion

            #region IndexOf

            //İndex Bulma
            //Metodun parametresinde verilen değerin string içerisinde ilk geçtiği index'i döndürür. Eğer bulunamazsa -1 döndürür.
            ornekMetin = "BilgeAdam Yazılım ve Bilişim Akademisi";
            int index = ornekMetin.IndexOf("Yazılım");
            Console.WriteLine(index);

            #endregion

            #region LastIndexOf

            //Son İndex Bulma
            //Metodun parametresinde verilen değerin string içerisinde son geçtiği index'i döndürür. Eğer bulunamazsa -1 döndürür.
            ornekMetin = "BilgeAdam Yazılım ve Bilişim Akademisi";
            int sonIndex = ornekMetin.LastIndexOf("a");
            Console.WriteLine(sonIndex);

            #endregion

            #region Remove

            //Silme
            //Metodun parametresinde verilen index'ten başlayarak string'in o index dahil sonrasını siler. Eğer ikinci parametre verilirse o kadar karakter siler.
            ornekMetin = "BilgeAdam Yazılım ve Bilişim Akademisi";
            ornekMetin = ornekMetin.Remove(5, 5); //5. index'ten başlayarak 5 karakter siler.
            Console.WriteLine(ornekMetin);

            #endregion

            #region Replace

            //Değiştirme
            //Metodun parametresinde verilen değerin string içerisinde geçen tüm kısımlarını, ikinci parametrede verilen değerle değiştirir.

            ornekMetin = "BilgeAdam Yazılım ve Bilişim Akademisi";
            ornekMetin = ornekMetin.Replace("Adam", "Kadın");
            Console.WriteLine(ornekMetin);

            #endregion

            #region Split
            //Bölmek , Parçalamak
            //Metodun parametresinde verilen karaktere göre string'i böler ve bir dizi döndürür. Eğer parametre verilmezse boşluk karakterine göre böler.

            ornekMetin = "BilgeAdam Yazılım , Bilişim; Akademisi";
            string[] kelimeler = ornekMetin.Split(new char[] { ' ', ',', '.' }, StringSplitOptions.RemoveEmptyEntries); //Boşluk, virgül ve nokta karakterlerine göre böler ve boş elemanları atlar.
            foreach (var kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }


            #endregion

            #region Alıstırma - 1

            Console.WriteLine("Mail Gönderme Programı");
            Console.WriteLine("Kime: ");

            string mailAdresleri = Console.ReadLine();
            string[] mailler = mailAdresleri.Split(';');
            //Kullanıcıdan alınan mail adreslerini noktalı virgülle ayırarak bir diziye atıyoruz.
            foreach (var mail in mailler)
            {
                if (mail.Contains("@"))
                {
                    Console.WriteLine("Mail Gönderildi: " + mail);
                }
                else
                {
                    Console.WriteLine("Geçersiz Mail Adresi: " + mail);
                }
            }

            #endregion

            #region Insert

            //Araya eklemek 
            //Metodun parametresinde verilen index'e, ikinci parametrede verilen değeri ekler. Eğer index string'in uzunluğundan büyükse hata verir.
            ornekMetin = "BilgeAdam Yazılım ve Bilişim Akademisi";
            ornekMetin = ornekMetin.Insert(5, " Kadın");
            Console.WriteLine(ornekMetin);
            #endregion

            #region ToLowerToUpper

            //Küçük Harfe Çevirme / Büyük Harfe Çevirme

            ornekMetin = "BilgeAdam Yazılım ve Bilişim Akademisi";
            ornekMetin = ornekMetin.ToLower(); //Küçük harfe çevirir.
            Console.WriteLine(ornekMetin);
            ornekMetin = ornekMetin.ToUpper(); //Büyük harfe çevirir.
            Console.WriteLine(ornekMetin);


            #endregion

            #region Substring

            //Alt Dize Alma
            //Metodun parametresinde verilen index'ten başlayarak string'in o index dahil sonrasını alır. Eğer ikinci parametre verilirse o kadar karakter alır.
            ornekMetin = "BilgeAdam Yazılım ve Bilişim Akademisi";
            string altDize = ornekMetin.Substring(3, 3); //3. index'ten başlayarak 3 karakter alır.
            Console.WriteLine(altDize);

            #endregion

            #region Trim
            //Kırpma
            //Metodun parametresinde verilen karakterleri string'in başından ve sonundan siler. Eğer parametre verilmezse boşluk karakterlerini siler.
            ornekMetin = "   BilgeAdam Yazılım ve Bilişim Akademisi   ";
            ornekMetin = ornekMetin.Trim(); //Boşluk karakterlerini siler.
            Console.WriteLine($"'{ornekMetin}'"); //Kırpılmış metni yazdırır.
            ornekMetin = ornekMetin.Trim('B', 'i'); //B ve i karakterlerini başından ve sonundan siler.
            Console.WriteLine($"'{ornekMetin}'"); //Kırpılmış metni yazdırır.

            #endregion

            #region Alıstırma - 2
            //Kullanıcıdan alınan bir cümle içindeki kelime sayısını ve cümlede geçen en uzun kelimenin uzunluğunu bulan bir C# programı yazıyoruz.
            Console.WriteLine("Lütfen bir cümle giriniz: ");
            string sentence = Console.ReadLine();

            string[] words = sentence.Split(' ');

            int wordCount = words.Length;

            Console.WriteLine($"Cümledeki kelime sayısı: {wordCount}");

            int maxLength = 0;
            foreach (var word in words)
            {
                int length = word.Length;
                if (length > maxLength)
                {
                    maxLength = length;
                }
            }

            Console.WriteLine($"Cümledeki en uzun kelimenin uzunluğu: {maxLength}");

            #endregion
        }
    }
}
