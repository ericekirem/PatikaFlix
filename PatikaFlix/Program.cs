using System;
using System.Collections.Generic;
using System.Linq;

namespace Patikaflix
{
    // Dizi sınıfı: Kullanıcıdan alınan tüm özellikler bu sınıfta tanımlanır.
    public class Dizi
    {
        public string Ad { get; set; }
        public string Tur { get; set; }
        public string Yonetmen { get; set; }
        public int YayinYili { get; set; }
        public int BolumSayisi { get; set; }
    }

    // KomediDizisi sınıfı: Sadece Dizi Adı, Tür ve Yönetmen bilgilerini içerir.
    public class KomediDizisi
    {
        public string Ad { get; set; }
        public string Tur { get; set; }
        public string Yonetmen { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Diziler için ana liste
            List<Dizi> diziler = new List<Dizi>();

            // Kullanıcıdan dizi bilgilerini alma
            while (true)
            {
                Console.WriteLine("Yeni bir dizi ekleyin:");

                Dizi dizi = new Dizi();

                Console.Write("Dizi Adı: ");
                dizi.Ad = Console.ReadLine();

                Console.Write("Dizi Türü: ");
                dizi.Tur = Console.ReadLine();

                Console.Write("Yönetmen: ");
                dizi.Yonetmen = Console.ReadLine();

                Console.Write("Yayın Yılı: ");
                dizi.YayinYili = int.Parse(Console.ReadLine());

                Console.Write("Bölüm Sayısı: ");
                dizi.BolumSayisi = int.Parse(Console.ReadLine());

                diziler.Add(dizi);

                Console.Write("Yeni bir dizi eklemek istiyor musunuz? (E/H): ");
                string devam = Console.ReadLine();
                if (devam.ToUpper() != "E")
                    break;
            }

            // Komedi dizilerinden yeni bir liste oluşturma
            List<KomediDizisi> komediDizileri = diziler
                .Where(d => d.Tur.ToLower() == "komedi") // Türü "komedi" olanları seç
                .Select(d => new KomediDizisi // KomediDizisi nesnesi oluştur
                {
                    Ad = d.Ad,
                    Tur = d.Tur,
                    Yonetmen = d.Yonetmen
                })
                .OrderBy(k => k.Ad) // Önce dizi adına göre sırala
                .ThenBy(k => k.Yonetmen) // Sonra yönetmen adına göre sırala
                .ToList();

            // Komedi dizilerini yazdırma
            Console.WriteLine("\nKomedi Dizileri:");
            foreach (var kDizi in komediDizileri)
            {
                Console.WriteLine($"Ad: {kDizi.Ad}, Tür: {kDizi.Tur}, Yönetmen: {kDizi.Yonetmen}");
            }
        }
    }
}
