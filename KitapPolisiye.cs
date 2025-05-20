using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    public class KitapPolisiye : Kitap  //kitaptan kalitim aliniyor
    {
        public string SucTipi { get; set; }
        public string Dedektif { get; set; }
    }
}
