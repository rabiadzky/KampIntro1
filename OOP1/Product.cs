using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet tab tuşuna basdıklarımız
    class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } //foreign key //hangi kategoriye ait
        public string ProductName { get; set; } //urunun adı
        public double UnitPrice { get; set; } //urunun fiyatı
        public int UnitsInStock { get; set; } //urunun stok adedi
         

    }
}
