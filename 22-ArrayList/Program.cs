using System.Collections;

namespace _22_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Şuana kadar öğrendiğimiz ilkel dizelerde veri tipi ve boyut tanımlama zorunluluğu vardı.
            //Listelerde boyut sorununu ortadan kaldırdık.
            //ArrayList ise hem boyut hem de tip zorunluluğunu ortadan kaldırır.

            ArrayList yeniListe = new ArrayList() { "Fatih", 34, true };
            yeniListe.Add("Alkan");
            yeniListe.Add("Büşra");
            yeniListe.Add(12);
            yeniListe.Add(50);

            ArrayList notlar = new ArrayList() { 10, 20, 10 };
            notlar.Add(20);
            //notlar.Add("otuz");
            notlar.Add(30);
            notlar.Add(40);
            foreach (var item in notlar)
            {
                Console.WriteLine(Convert.ToInt32(item) * 2);
            }

            object[] objects = new object[] { 10, "otuz" };
            List<object> objectList = new List<object>();
        }
    }
}
