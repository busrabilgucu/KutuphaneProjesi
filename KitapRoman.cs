using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    public class KitapRoman : Kitap //kitaptan kalitim aliniyor
    {
        public string Konu { get; set; }
        public bool UzunMu { get; set; }

    }
}
