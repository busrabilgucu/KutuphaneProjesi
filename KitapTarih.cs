using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    public class KitapTarih : Kitap //kitaptan kalitim aliniyor
    {
        public string TarihDonemi { get; set; }
        public string Olay { get; set; }
        public string Kisiler { get; set; }
    }
}
