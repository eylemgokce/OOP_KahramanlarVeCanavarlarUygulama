using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KahramanlarVeCanavarlarUygulama
{
    public class Canavar : Karakter
    {
        public int zehirGucu;

        public Canavar(string isim, int saglik, int saldirigucu, int savunma ,int zehirGucu) : base(isim, saglik, saldirigucu, savunma)
        {
            this.zehirGucu = zehirGucu;
        }

        public void zehirliSaldiri(Karakter hedef)
        {
            hedef.saglik -= zehirGucu;
            Console.WriteLine(isim + " " + hedef.isim + "'e zehirli saldırı yaptı!");

        }
    }
}
