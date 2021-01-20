using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation: class kumelenmiş şekilde gider.
        //ekleme
        public void Add(Product product) //Product turunde product ver.//101 adresteki değer kamera olduğu için kamera çıktı
        {
            // product.ProductName = "Kamera";
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        //guncelleme
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName +" guncellendi.");
        }




       /* public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
        //
        //topla2 sayiları topluyor ekrana yazdırıyor.
        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine( sayi1 + sayi2);//3ile6yi toplar 9 yazar
        }*/

        /* public void BiseyYap(int sayi)
         {
             sayi = 99;
         }*/
    }
}
