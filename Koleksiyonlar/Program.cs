using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Murat", "Kerem", "Halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];//bu şekilde çalışır fakat verdiğimiz değerleri kaybederiz isimlerin adresi yeni bir adres(isimler=new string[])
            //isimler[4] = "İlker";           
                     
            //Console.WriteLine(isimler[4]);//arrayler oluşturulan sınırlarda takılır o sınırın dışına çıkaramayız.
            //Console.WriteLine(isimler[0]);
            //ctrl k+c yorum satırı
            //ctrl k+u?

            //array sabittir. 
            //new yeni referans adresi demektir. eski verilen değerler kaybolur.
            //değer tipler sadece stack kullanır.
            //referans tipler hem stack hem heap kullanır


            List<string> isimler2 = new List<string> {"Engin","Murat","Kerem","Halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);





        }    
    }
}
