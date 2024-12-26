using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KahramanlarVeCanavarlarUygulama
{
    public abstract class Karakter 
    {
        public string isim;
        public int saglik;
        public int saldirigucu;
        public int savunma;

        public Karakter(string isim, int saglik, int saldirigucu, int savunma)
        {
            this.isim = isim;
            this.saglik = saglik;
            this.saldirigucu = saldirigucu;
            this.savunma = savunma;
        }

        public virtual void saldir(Karakter hedef)
        {
            int hasar = saldirigucu - hedef.savunma;
            if(hasar > 0)
            {
                hedef.saglik -= hasar; 
            }
            Console.WriteLine(isim + " " + hedef.isim + "'e " + hasar + " hasar verdi");
        }
        

        
    }
}
