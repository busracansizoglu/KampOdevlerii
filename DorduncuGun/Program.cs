using System;

namespace DorduncuGun
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictonary<string> sehirler = new MyDictonary<string>();
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Length);

            sehirler.Add("İstanbul");
            sehirler.Add("Rize");
            sehirler.Add("Samsun");
            Console.WriteLine(sehirler.Length);

            foreach (var sehir in sehirler.Items)
            {
                Console.WriteLine(sehir);
            }


        }
    }
}
