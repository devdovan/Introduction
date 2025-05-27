namespace _16_LABAsalSayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Bir sayı giriniz: ");
                int sayi = int.Parse(Console.ReadLine());
                Console.Write("Asal mı?  ");
                bool asalMi = true;
                if (sayi < 2)
                {
                    asalMi = false;
                }

                for (int i = 2; i <= Math.Sqrt(sayi); i++)
                {
                    if (sayi % i == 0)
                    {
                        asalMi = false;

                    }
                }

                Console.WriteLine(asalMi);

            }
        }
    }
}
