using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();//101
            product1.Id = 1;
            product1.CategoryId = 2;//arka planda mobilya 
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            //her iki şekildede tanımlanabilir.
            //categoryId=5 kırtasiye kategorisi 
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //case sensitive =buyuk kucuk harf duyarlılığı
            //PascalCase   //camelCase 
            ProductManager productManager = new ProductManager(); //ProductManager turundeki productManager yeni referans aldı.
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName); //kamera çıkar
                                                     //bellekteki/ adresteki değer kamera olduğu için kamera çıktı
                                                     //olay referans değeri uzerinden gidiyor. 

            //int sayi = 100;
            //productManager.BiseyYap(sayi);
            //Console.WriteLine(sayi); //100 çıkar 
            //referanslarda bellek adresi dikkate alınır

            /*productManager.Topla2(3, 6); //bu çıkan sonucu tekrardan kullanmak istediğimizde kullanamıyoruz!!! 
            int toplamaSonucu = productManager.Topla(3, 6); //burada çıkan sonucu toplama sonucuna atıyoruz.
            Console.WriteLine(toplamaSonucu * 2);//return ile yazılan ı tekrardan kullanabiliyoruz.*/
            
        }
    }
}
