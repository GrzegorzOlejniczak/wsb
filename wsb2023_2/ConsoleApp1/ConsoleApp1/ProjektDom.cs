using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Dom
    {
        const int iloscOkien = 10;
        private double metraz = 200;
        private string adres;

        public Dom() {
            adres = "nieznany";
        }
        public Dom(string adres_)
        {
            adres = adres_;
        }

        public string Adres
        {
            get { return adres; }
            set { adres = value; }

        }
        public double ObliczPodatek(double podatekZaMetr)
        {
            return podatekZaMetr * metraz;
        }
    }
}
