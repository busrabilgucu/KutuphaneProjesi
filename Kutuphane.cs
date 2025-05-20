using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    public class Kutuphane
    {
        // Kitap turleri icin somut bir sinifta belirtme islemi
        private readonly GenelIslemler<KitapBilim> kitapBilimIslemleri = new GenelIslemler<KitapBilim>();
        private readonly GenelIslemler<KitapRoman> kitapRomanIslemleri = new GenelIslemler<KitapRoman>();
        private readonly GenelIslemler<KitapTarih> kitapTarihIslemleri = new GenelIslemler<KitapTarih>();
        private readonly GenelIslemler<KitapPolisiye> kitapPolisiyeIslemleri = new GenelIslemler<KitapPolisiye>();
        private readonly GenelIslemler<KitapPsikoloji> kitapPsikolojiIslemleri = new GenelIslemler<KitapPsikoloji>();

        // Kitap ekleme
        public void KitapEkle(Kitap kitap)
        {
            if (kitap is KitapBilim kitapBilim)
                kitapBilimIslemleri.Ekle(kitapBilim);
            else if (kitap is KitapRoman kitapRoman)
                kitapRomanIslemleri.Ekle(kitapRoman);
            else if (kitap is KitapTarih kitapTarih)
                kitapTarihIslemleri.Ekle(kitapTarih);
            else if (kitap is KitapPolisiye kitapPolisiye)
                kitapPolisiyeIslemleri.Ekle(kitapPolisiye);
            else if (kitap is KitapPsikoloji kitapPsikoloji)
                kitapPsikolojiIslemleri.Ekle(kitapPsikoloji);
        }

        // Tum kitapları listeleme
        public void TumKitaplariGoster()
        {
            Console.WriteLine("Tüm Kitaplar:");

            foreach (var kitap in kitapBilimIslemleri.HepsiniGetir())
            {
                kitap.KitapBilgileriniGoster();
            }

            foreach (var kitap in kitapRomanIslemleri.HepsiniGetir())
            {
                kitap.KitapBilgileriniGoster();
            }

            foreach (var kitap in kitapTarihIslemleri.HepsiniGetir())
            {
                kitap.KitapBilgileriniGoster();
            }

            foreach (var kitap in kitapPolisiyeIslemleri.HepsiniGetir())
            {
                kitap.KitapBilgileriniGoster();
            }

            foreach (var kitap in kitapPsikolojiIslemleri.HepsiniGetir())
            {
                kitap.KitapBilgileriniGoster();
            }
        }
    }
}
