using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    public abstract class Kitap : TemelVarlik
    {
        public string Ad { get; set; }
        public string ISBN { get; set; }
        public string Baslik { get; set; }
        public string Yazar { get; set; }
        public int YayınYılı { get; set; }
        public string Dil { get; set; }
        public Durum KitapDurumu { get; set; }

        // Kitap bilgilerini gosteren metod
        public void KitapBilgileriniGoster()
        {
            Console.WriteLine($"Kitap Bilgileri: \nISBN: {ISBN}\nBaşlık: {Baslik}\nYazar: {Yazar}\nYıl: {YayınYılı}\nDil: {Dil}\nDurum: {KitapDurumu}");
        }

    }
}
