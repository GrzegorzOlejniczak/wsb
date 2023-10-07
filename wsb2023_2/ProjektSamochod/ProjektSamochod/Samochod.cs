using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjektSamochod
{
    internal class Samochod
    {
        private string marka;
        private string model;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        private double srednieSpalanie;
        private static int liczbaSamochodow = 0;

        public Samochod() 
        {
            marka = "nieznany";
            model = "nieznany";
            iloscDrzwi = 0;
            pojemnoscSilnika = 0;
            srednieSpalanie = 0;
            liczbaSamochodow = 0;
        }
       
        public Samochod(string marka_, string model_, int iloscDrzwi_, double srednieSpalanie_)
        {
            marka = marka_;
            model = model_;
            iloscDrzwi = iloscDrzwi_;
            srednieSpalanie = srednieSpalanie_;
            liczbaSamochodow++;
        }

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int IloscDrzwi
        {
            get { return iloscDrzwi; }
            set { iloscDrzwi = value; }
        }
        public double SrednieSpalanie
        {
            get { return srednieSpalanie; }
            set { srednieSpalanie = value; }
        }

        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return (srednieSpalanie * dlugoscTrasy) / 100;
        }

        public double ObliczKosztPrzejazdu(double dlugoscTrasy, double cenaPaliwa)
        {
            double spalanie = ObliczSpalanie(dlugoscTrasy);
             return spalanie * cenaPaliwa;
        }

        public void WypiszInfo()
        {
            Console.WriteLine("Marka: " + marka);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("IloscDrzwi: " + iloscDrzwi);
            Console.WriteLine("Pojemnosc Silnika: " + pojemnoscSilnika);
        }

        public static void WypiszIloscSamochodow()
        {
            Console.WriteLine(liczbaSamochodow);
        }
    }
}
