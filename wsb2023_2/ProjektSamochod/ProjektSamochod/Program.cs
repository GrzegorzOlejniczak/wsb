using System;
using ProjektSamochod;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace ProjektSamochod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Samochod s1 = new Samochod();
            s1.WypiszInfo();
            s1.Model = "126p";
            s1.IloscDrzwi = 2;
            s1.SrednieSpalanie = 6.0;

            s1.WypiszInfo();

            Samochod s2 = new Samochod("Syrena", "105", 2, 7.6);
            s2.WypiszInfo();
        }
    }
}
