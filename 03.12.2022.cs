using System;
using System.IO;

namespace ConsoleApp23
{
    class Program
    {
        static void Main(string[] args)
        {



            //double[] tab  = { 1, 2, 3, 4, 5, 6, 7 };

            //double[] kopia = (double[])tab.Clone();


            //int* a;
            //int b = 5;

            //a = &b;

            //Console.WriteLine("Wartość b: " + b);
            //Console.WriteLine("Adres w pamięci "+(int)a);

            //int d = 10;
            //int* c = &d;

            //b = d;

            //*a = *c;
            //Console.WriteLine("wartość b: " + b);


            //Console.Write("POdaj ścieżkę do pliku : ");
            string sciezka = "C:\\Users\\student\\Downloads\\dane.csv";


            string folder = Path.GetDirectoryName(sciezka);
            string nazwaPlikuBezRoz = Path.GetFileNameWithoutExtension(sciezka);
            string nowyFolder = Path.Combine(folder, nazwaPlikuBezRoz);
            Console.WriteLine(nowyFolder);
            Directory.CreateDirectory(nowyFolder);
            using (StreamReader sr = new StreamReader(sciezka))
            {

                string naglowek = sr.ReadLine();
                string[] elementyNaglowka = naglowek.Split(";");
                while (!sr.EndOfStream)
                {
                Console.WriteLine(sr.ReadLine());


                }
            }

           


        }
    }
}
