using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rabia Duzkaya
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Rabia";
            musteri1.Soyadi = "Duzkaya";
            musteri1.TcNo = "12345678910";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "1234567890";


            //Gerçek musteri - Tuzel musteri ikiside musteri evet ama farklı musteri tipleri bunlar birbirlerinin yerine kullanılamazlar.
            //SOLID 

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            //musteri classı hem gercekusterinin referansını hem tuzelmusterinin referansını tutabiliyor.
            // new bellekteki referans no.(?)
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
        }
    }
}
