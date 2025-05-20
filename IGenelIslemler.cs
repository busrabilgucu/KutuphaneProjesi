using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    public interface IGenelIslemler<T> where T : Kitap, new()
    {
        bool Ekle(T varlik); // Kitap ekleme işlemi
        T Getir(int index);  // Belirli bir kitaba erişim
        List<T> HepsiniGetir();  // Tüm kitapları listeleme
        bool Sil(int index);  // Kitap silme işlemi
    }
}
