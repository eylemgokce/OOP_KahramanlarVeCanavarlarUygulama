using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KahramanlarVeCanavarlarUygulama
{
    public class Kahraman : Karakter
    {
        public int buyuGucu;
        public Kahraman(string isim, int saglik, int saldirigucu, int savunma ,int buyuGucu) : base(isim, saglik, saldirigucu, savunma)
        {
            this.buyuGucu = buyuGucu;
        }

        public void buyuYap(Karakter hedef)
        {
            if(buyuGucu > 0)
            {
                buyuGucu -= 10;
                hedef.saglik = saldirigucu * 2;
                Console.WriteLine(isim + hedef.isim + "'e büyü yaptı!");
            }
            else
            {
                Console.WriteLine(isim + "'in yeterli büyüsü yok!");
            }
        }
    }
}
