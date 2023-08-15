using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_proje
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            musteri M1 = new musteri();
            M1.Name = "samet";
            M1.Id = 1;
            M1.Sorname = "firat";
            M1.Password ="password";
            M1.Email = "samet.firat";
            M1._kulancıAdı = "sametfırat";
            musteri.ekle(M1);

            musteri M2 = new musteri();
            M2.Name = "ali";
            M2.Id = 1;
            M2.Sorname = "firat";
            M2.Password = "password";
            M2.Email = "fatih.firat";
            M2._kulancıAdı = "fatih";
            musteri.ekle(M2);

            musteri M3 = new musteri();
            M3.Name = "samet";
            M3.Id = 1;
            M3.Sorname = "firat";
            M3.Password = "password";
            M3.Email = "samet.firat";
            M3._kulancıAdı = "sametfırat";
            musteri.ekle(M3);

        }
    }
}
