using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_KahramanlarVeCanavarlarUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *Hikaye: Kahramanlar ve Canavarlar

             Bir macera dünyasında, farklı kahramanlar ve canavarlar yaşar. 
             Kahramanlar, canavarlarla savaşarak dünyayı kurtarmaya çalışır. 
             Her kahraman ve canavarın kendine özgü özellikleri vardır. 
             Bu hikaye üzerinden, sınıflar, miras (inheritance), polimorfizm,
             arayüzler ve nesne yönetimi gibi OOP kavramlarını öğretici bir şekilde uygulayacağız.

             */


            Kahraman kahraman = new Savasci("Zito", 100, 15, 10, 30);
            Canavar canavar = new Canavar("Goblin", 100, 15, 10, 30);

            Console.WriteLine("Savaş başlıyor : " + kahraman.isim + " vs " + canavar.isim);

            while(kahraman.saglik > 0 && canavar.saglik > 0)
            {
                kahraman.saldir(canavar);
                if (canavar.saglik <= 0)
                {
                    Console.WriteLine(canavar.isim + " yenildi");
                    break;
                }

                canavar.zehirliSaldiri(kahraman);
                if(kahraman.saglik <= 0)
                {
                    Console.WriteLine(kahraman.isim + " yenildi!");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
