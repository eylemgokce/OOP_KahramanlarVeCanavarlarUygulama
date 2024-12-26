using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KahramanlarVeCanavarlarUygulama
{
    public class Savasci : Kahraman, IOzelHareket
    {
        public Savasci(string isim, int saglik, int saldirigucu, int savunma, int buyuGucu) : base(isim, saglik, saldirigucu, savunma, buyuGucu)
        {
        }

        public void OzelHareket(Karakter hedef)
        {
            Console.WriteLine(isim + " güçlü bir kılıç darbesi yaptı!");
            hedef.saglik -= saldirigucu * 3;
        }
    }
}
