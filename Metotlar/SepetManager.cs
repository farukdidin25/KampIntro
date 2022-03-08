using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikle rsepete ekledi : " + " " + urun.Name);
        }

        public void Ekle2(string Name, string Aciklama, double fiyat)
        {
            Console.WriteLine("Eklendi :"+ " "+Name);
        }



    }
}
