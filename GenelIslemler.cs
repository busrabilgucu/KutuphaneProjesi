using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{

    public class GenelIslemler<T> where T : Kitap, new()  // Generic yapi kullandik.
    {
        protected static List<T> list = new List<T>();
        // Kitap ekleme:
        public bool Ekle(T varlik)
        {
            try
            {
                var i = list.Count;
                list.Add(varlik);
                return i < list.Count;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hata: {ex.Message}");
                return false;
            }
        }
        // Belirli bir kitabi getir.
        public T Getir(int index)
        {
            try
            {
                return list[index];
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Hata: Geçersiz indeks. Lutfen dogru bir indeks giriniz!");
                return null;
            }
        }
        // Tum kitaplari listele
        public List<T> HepsiniGetir()
        {
            return list;
        }

        // kitap silme
        public bool Sil(int index)
        {
            try
            {
                var i = list.Count;
                list.RemoveAt(index);
                return list.Count < i;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Hata: Geçersiz indeks.");
                return false;
            }
        }
    }
}
