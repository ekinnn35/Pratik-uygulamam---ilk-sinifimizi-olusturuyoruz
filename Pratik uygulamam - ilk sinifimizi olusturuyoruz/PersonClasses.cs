using System;

namespace OkulYonetimSistemi
{
    // Person sınıfı: Ortak özellikleri içerir
    public class Person
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }

        // Ortak bir metot: Bilgileri konsola yazdırır
        public void BilgiGetir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Doğum Tarihi: {DogumTarihi.ToShortDateString()}");
        }
    }

    // Öğrenci sınıfı: Person sınıfından türetilmiş
    public class Ogrenci : Person
    {
        public string Sinif { get; set; } // Öğrencinin sınıfı
    }

    // Öğretmen sınıfı: Person sınıfından türetilmiş
    public class Ogretmen : Person
    {
        public string Branş { get; set; } // Öğretmenin branşı
    }
}
