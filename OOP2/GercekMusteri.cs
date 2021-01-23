using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Individual(gerçek)
    //:musteri --> Miras(Inheritance)
    //gerçek musteri de bir musteridir.
    //Musteride olan özellikler hem gerçekte hem tuzelde vardır. 
    class GercekMusteri:Musteri
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
