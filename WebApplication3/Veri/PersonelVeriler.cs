using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication3.Models;

namespace WebApplication3.Veri
{
    public class PersonelVeriler
    {
        public static List<Personel> listPersoneller = new List<Personel>()
        {
            new Personel
            {
                Id=1,
                Ad="Ali",
                Soyad="Hazır asdadad",
                TCKN =11111111111,
                DogumTarihi=new DateTime(1990,12,28)


            },
            new Personel
            {

                Id=2,
                Ad="Veli",
                Soyad="Hazır",
                TCKN =11111111111,
                DogumTarihi=new DateTime(2000,12,28)
            },

              new Personel
            {

                Id=3,
                Ad="deli",
                Soyad="Hazır",
                TCKN =11111111111,
                DogumTarihi=new DateTime(1981,12,28)
            },


        };


    }
}