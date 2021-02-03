using System;

namespace Banka
{
    class Program
    {

        static void Main(string[] args)
        {
            Hesap hesap1 = new Hesap("Can Halfeoğulları", 200);
            Console.WriteLine("Hesap Sahibi: " + hesap1.HesapSahibi);
            Console.WriteLine("Bakiye: {0:n2}₺",hesap1.Bakiye);
            Console.WriteLine("50 lira para çekelim...");
            hesap1.ParaCek(50);
            Console.WriteLine("Bakiye: {0:n2}₺", hesap1.Bakiye);

            Console.ReadKey();
        }
    }
}
