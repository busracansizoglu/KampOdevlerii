using System;

namespace IkinciGun
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.KitapAdi = "Zamanın Kısa Tarihi";
            urun1.YazarAdi = "Stephen Hawking";
            urun1.Fiyati = 22.40;

            Urun urun2 = new Urun();
            urun2.KitapAdi = "Sokrates'in Savunması";
            urun2.YazarAdi = "Platon";
            urun2.Fiyati = 8.95;

            Urun urun3 = new Urun();
            urun3.KitapAdi = " 1984";
            urun3.YazarAdi = " George Orwel";
            urun3.Fiyati = 14.80;

            Urun urun4 = new Urun();
            urun4.KitapAdi = " Osmanlı Tarihinde Efsaneler ve Gerçekler";
            urun4.YazarAdi = " Halil İnalcık";
            urun4.Fiyati = 27.60;

            Urun[] uruns = new Urun[] { urun1, urun2, urun3, urun4 };

            Console.WriteLine("*********************FOR DÖNGÜSÜ**************************");

            for (int i = 0; i < uruns.Length; i++)
            {
                Console.WriteLine("Kitap Adı : " + uruns[i].KitapAdi);
                Console.WriteLine("Yazar Adı : " + uruns[i].YazarAdi);
                Console.WriteLine("Fiyatı : " + uruns[i].Fiyati);
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("****************FORENCH DÖNGÜSÜ***************************");

            foreach (var urunler in uruns)
            {
                Console.WriteLine("Kitap Adı : " + urunler.KitapAdi);
                Console.WriteLine("Yazar Adı : " + urunler.YazarAdi);
                Console.WriteLine("Fiyatı : " + urunler.Fiyati);
                Console.WriteLine("----------------------------------");
            }

            Console.WriteLine("******************WHİLE DÖNGÜSÜ***************************");
            int sayac = 0;
            while (sayac < uruns.Length)
            {
                Console.WriteLine("Kitap Adı : " + uruns[sayac].KitapAdi);
                Console.WriteLine("Yazar Adı : " + uruns[sayac].YazarAdi);
                Console.WriteLine("Fiyatı : " + uruns[sayac].Fiyati);
                Console.WriteLine("------------------------------------");
                sayac++;
            }
        }

    }



}