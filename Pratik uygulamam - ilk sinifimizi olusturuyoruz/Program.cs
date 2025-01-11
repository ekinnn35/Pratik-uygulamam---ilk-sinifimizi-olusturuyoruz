using System;
using OkulYonetimSistemi; // Person sınıflarını içeren namespace'i kullanıyoruz

namespace OkulYonetimSistemiApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Öğrenci nesneleri oluşturuluyor
            Ogrenci ogrenci1 = new Ogrenci
            {
                Ad = "Ali",
                Soyad = "Atay",
                DogumTarihi = new DateTime(2002, 3, 02),
                Sinif = "9-C"
            };

            Ogrenci ogrenci2 = new Ogrenci
            {
                Ad = "Ali",
                Soyad = "Koç",
                DogumTarihi = new DateTime(2006, 6, 24),
                Sinif = "12-D"
            };

            // Öğretmen nesneleri oluşturuluyor
            Ogretmen ogretmen1 = new Ogretmen
            {
                Ad = "Aziz",
                Soyad = "Yıldırım",
                DogumTarihi = new DateTime(1960, 09, 10),
                Branş = "Akıl"
            };

            Ogretmen ogretmen2 = new Ogretmen
            {
                Ad = "Ajda",
                Soyad = "Pekkan",
                DogumTarihi = new DateTime(1900, 1, 01),
                Branş = "Tarih"
            };

            // Bilgileri konsola yazdırma
            Console.WriteLine("Öğrenciler:");
            ogrenci1.BilgiGetir();
            Console.WriteLine($"Sınıf: {ogrenci1.Sinif}\n");

            ogrenci2.BilgiGetir();
            Console.WriteLine($"Sınıf: {ogrenci2.Sinif}\n");

            Console.WriteLine("Öğretmenler:");
            ogretmen1.BilgiGetir();
            Console.WriteLine($"Branş: {ogretmen1.Branş}\n");

            ogretmen2.BilgiGetir();
            Console.WriteLine($"Branş: {ogretmen2.Branş}\n");

            Console.ReadKey(); // Konsol ekranını açık tutar
        }
    }
}
