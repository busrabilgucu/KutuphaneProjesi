using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    public class KitapBilim : Kitap   //kitaptan kalitim aliniyor
    {
        public string Konu { get; set; }
        public string Alan { get; set; }
        public int SayfaSayisi { get; set; }
    }
}
