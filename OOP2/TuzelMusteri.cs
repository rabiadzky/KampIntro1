using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Corporate(Tuzel)
    //:musteri --> Miras(Inheritance)
    //tuzel musteri bir musteridir. 
    //Musteride olan özellikler hem gerçekte hem tuzelde vardır. 
    class TuzelMusteri :Musteri
    {        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
