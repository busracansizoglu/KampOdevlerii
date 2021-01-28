using System;

namespace UcuncuGun_ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 120;
            musteri1.Ad = "Engin";
            musteri1.Soyad = "Demiroğ";
            musteri1.Email = "engindemirog@kodlama.io";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 121;
            musteri2.Ad = "Büşra Nur";
            musteri2.Soyad = "Cansızoğlu";
            musteri2.Email = "busracansizoglu@gmail.com";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Guncelle(musteri2);
            musteriManager.Silme(musteri2);
        }
    }
}
