using System;
using System.Collections.Generic;
using System.Text;

namespace UcuncuGun_ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Sayın ; " + musteri.Ad + musteri.Soyad + " Kaydınız Tamamlandı!");
        }
        public void Guncelle(Musteri musteri)
        {
            Console.WriteLine("Sayın ; " + musteri.Ad + musteri.Soyad + " Güncelleme Tamamlandı!");
        }

        public void Silme(Musteri musteri)
        {
            Console.WriteLine("Sayın ; " + musteri.Ad + musteri.Soyad + " Silme İşleminiz Gerçekleştirildi!");
        }
    }
}
