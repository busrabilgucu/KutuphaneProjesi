using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneProjesi
{
    public class KitapPsikoloji : Kitap  //kitaptan kalitim aliniyor
    {
        public string PsikolojiAltAlan { get; set; }  // Psikolojinin alt alani 
        public string TedaviYontemi { get; set; }
    }
}
