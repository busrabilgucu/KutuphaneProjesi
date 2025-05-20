using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    public class Uye : TemelVarlik, IUye
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int UyeNumarasi { get; set; }
        public List<Kitap> OduncAldigiKitaplar { get; set; } = new List<Kitap>();
        public int OduncAlmaLimiti { get; set; } = 5;  // odunc alma limiti 5
        public List<Kitap> OduncAlinanKitaplar { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool OduncAl(Kitap kitap, List<Uye> kutuphaneUyeleri)
        {
            if (!kutuphaneUyeleri.Contains(this))
            {
                Console.WriteLine($"Hata: {Ad} {Soyad} kütüphane sistemine kayıtlı değil. Ödünç alma işlemi başarısız.");
                return false;
            }
            else if (kitap.KitapDurumu == Durum.OduncAlinabilir && OduncAldigiKitaplar.Count < OduncAlmaLimiti)
            {
                kitap.KitapDurumu = Durum.OduncVerilmis;
                OduncAldigiKitaplar.Add(kitap);
                return true;
            }
            return false;
        }

        public bool IadeEt(Kitap kitap)
        {
            if (OduncAldigiKitaplar.Contains(kitap))
            {
                kitap.KitapDurumu = Durum.OduncAlinabilir;
                OduncAldigiKitaplar.Remove(kitap);
                return true;
            }
            return false;
        }
    }
}
