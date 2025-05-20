using KutuphaneProjesi;

internal class Program
{
    private static void Main(string[] args)
    {
        // Kutuphane uye olusturma
        var KutuphaneUye1 = new Uye { Ad = "Busra", Soyad = "Bilgucu", UyeNumarasi = 1 };
        var KutuphaneUye2 = new Uye { Ad = "Ali", Soyad = "Veli", UyeNumarasi = 2 };
        var Kutuphaneuye3 = new Uye { Ad = "Ahmet", Soyad = "Mehmet", UyeNumarasi = 3 };
        var kutuphaneUyeleri = new List<Uye> { KutuphaneUye1, KutuphaneUye2, Kutuphaneuye3 };

        // Kitaplar:
        KitapBilim kitap1 = new KitapBilim
        {
            ISBN = "453216598132",
            Baslik = "Kozmos ",
            Yazar = "Carl Sagan",
            YayınYılı = 1980,
            KitapDurumu = Durum.OduncAlinabilir,
            Alan = "Bilim",
            Dil = "İngilizce",
            Konu = "Bilimsel",
            SayfaSayisi = 240
        };

        KitapRoman kitap2 = new KitapRoman
        {
            ISBN = "9783293005037",
            Baslik = "Beyaz Gemi",
            Yazar = "Cengiz Aytmatov",
            YayınYılı = 1970,
            KitapDurumu = Durum.OduncAlinabilir,
            Konu = "Roman",
            Dil = "Türkçe",
            UzunMu = false
        };

        KitapTarih kitap3 = new KitapTarih
        {
            ISBN = "9756461071",
            Baslik = "Zeytindağı",
            Yazar = "Falih Rıfkı Atay",
            YayınYılı = 1932,
            KitapDurumu = Durum.OduncAlinabilir,
            TarihDonemi = "I. Dünya Savaşı",
            Dil = "Türkçe",
            Olay = "Falih Rıfkı Atay'ın yedek subay olarak katıldığı I. Dünya Savaşı'ndaki anı ve izlenimlerinden olusur",
            Kisiler = "Falih Rıfkı Atay"
        };

        KitapPolisiye kitap4 = new KitapPolisiye
        {
            ISBN = "9780006511373",
            Baslik = "Acı Kahve",
            Yazar = "Agatha Christie",
            YayınYılı = 1930,
            KitapDurumu = Durum.OduncAlinabilir,
            SucTipi = "Cinayet",
            Dedektif = "Hercule Poirot",
            Dil = "İngilizce"
        };

        KitapPsikoloji kitap5 = new KitapPsikoloji
        {
            ISBN = "9786257118347",
            Baslik = "Başarılı Yaşlanma",
            Yazar = "Daniel J. Levitin",
            YayınYılı = 2023,
            KitapDurumu = Durum.OduncAlinabilir,
            PsikolojiAltAlan = "Sağlık",
            TedaviYontemi = "Psikolojik Rahatlama",
            Dil = "İngilizce"
        };

        // Kitap ve uye islemleri
        var kitapBilimIslemleri = new GenelIslemler<KitapBilim>();
        var kitapRomanIslemleri = new GenelIslemler<KitapRoman>();
        var kitapTarihIslemleri = new GenelIslemler<KitapTarih>();
        var kitapPsikolojiIslemleri = new GenelIslemler<KitapPsikoloji>();
        var kitapPolisiyeIslemleri = new GenelIslemler<KitapPolisiye>();

        kitapBilimIslemleri.Ekle(kitap1);
        kitapRomanIslemleri.Ekle(kitap2);
        kitapTarihIslemleri.Ekle(kitap3);
        kitapPolisiyeIslemleri.Ekle(kitap4);
        kitapPsikolojiIslemleri.Ekle(kitap5);

        // Uye odunc alma islemi
        Console.WriteLine("Kitap ödünç alma işlemi başlıyor...\n");

        // Yeni uye:
        var yeniUye = new Uye { Ad = "Kübra", Soyad = "Oz", UyeNumarasi = 4 };
        kutuphaneUyeleri.Add(yeniUye);  // Kubra Oz kutuphaneUyeleri listesine ekleniyor.

        // Kitap odunc alma:
        bool oduncAlindi = yeniUye.OduncAl(kitap1, kutuphaneUyeleri);
        if (oduncAlindi)
        {
            Console.WriteLine($"{yeniUye.Ad} {yeniUye.Soyad}", " {kitap1.Baslik} kitabini odunc aldi.");
        }
        else
        {
            Console.WriteLine($"{yeniUye.Ad} kitabi odunc alamadi.");
        }

        // Kitap bilgileri:
        kitap1.KitapBilgileriniGoster();
        kitap2.KitapBilgileriniGoster();
        kitap3.KitapBilgileriniGoster();
        kitap4.KitapBilgileriniGoster();
        kitap5.KitapBilgileriniGoster();

        // İade 
        Console.WriteLine("\nKitap iade ediliyor...");
        bool iadeSonucu = yeniUye.IadeEt(kitap1);
        if (iadeSonucu)
        {
            Console.WriteLine($"{yeniUye.Ad} {yeniUye.Soyad} {kitap1.Baslik} kitabini iade etti.");
        }
        else
        {
            Console.WriteLine($"{yeniUye.Ad} kitabi iade edemedi.");
        }

        // İade sonrasi kitap bilgileri
        kitap1.KitapBilgileriniGoster();
    }
}