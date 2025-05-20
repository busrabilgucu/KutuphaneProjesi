using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    public interface IUye
    {
        string Ad { get; set; }
        string Soyad { get; set; }
        int UyeNumarasi { get; set; }
        List<Kitap> OduncAlinanKitaplar { get; set; }
        bool OduncAl(Kitap kitap, List<Uye> kutuphaneUyeleri);
        bool IadeEt(Kitap kitap);

        int OduncAlmaLimiti { get; set; }  // Odunc alma limiti
    }
}
