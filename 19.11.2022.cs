using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            //zad5
            /*
            Console.Write("Podaj n:");
            int x = int.Parse(Console.ReadLine());
            int wylosowanaLiczba;
            Random random = new Random();

            int max = 1, min = 100;

            while (x>0)
            {

            wylosowanaLiczba = random.Next(1, 101);
                Console.WriteLine(wylosowanaLiczba);

                if (wylosowanaLiczba > max) max = wylosowanaLiczba;

                if (wylosowanaLiczba < min) min = wylosowanaLiczba;

                x--;

            }
            Console.WriteLine("max: " + max + " min: " + min);

             */
            /*
            void procedura()
            {
                int a, b;
                char znak;

                Console.Write("podaj a: ");
                a = int.Parse(Console.ReadLine());

                Console.Write("podaj b: ");
                b = int.Parse(Console.ReadLine());


                Console.WriteLine(a + b);
                Console.WriteLine(a - b);
                Console.WriteLine(a * b);

            if (b == 0) Console.WriteLine("nie można dzielić przez 0");
                else Console.WriteLine(a / b);

            }



            do
            {
            procedura();
                Console.WriteLine("Czy chcesz wprowadzić kolejne liczby? t/n: ");
                
            } while (Console.ReadLine()=="t");


            */

            /*

            uint liczbaWPrzedziale(uint[] tab, int a, int b)
            {
                uint licznik = 0;
                foreach(uint liczba in tab)
                {
                    if (liczba >= a && liczba <= b)
                    {
                        Console.WriteLine(liczba);
                        licznik++;
                    }
                }
                return licznik;
            }

            uint[] tab = { 3, 4, 5 };

            Console.WriteLine("Podaj n:");
            int a = int.Parse(Console.ReadLine());

            int[] tab1 = new int[a];

            Random random = new Random();

            for(int i=0; i<a; i++)
            {
                tab[i] = (uint)random.Next();
                //Console.
                

            }


            Console.WriteLine("Podaj a: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b; ");
            int y = int.Parse(Console.ReadLine());



            Console.WriteLine(liczbaWPrzedziale(tab, x, y));

            */

            //zad4
            /*

            uint NWD_iteracyjnie(int a, int b)
            {
                while (a != b)
                {
                    if (a > b) a = a - b;
                    else b = b - a;
                }
                return (uint)b;
                

            }

            uint NWD_rek(int a, int b)
            {
                if (a == b) return (uint)a;
                else if (a > b) return NWD_rek(a - b, b);
                else return NWD_rek(a, b - a);

            }

            Console.WriteLine(NWD_iteracyjnie(10, 5));
            Console.WriteLine(NWD_rek(10, 5));


            */


            double[] sortowanie(double[] tab)
            {
                  for(int i=0; i<tab.Length; i++)
                  {
                        for(int j=i+1; j<tab.Length; j++)
                        {
                            if (tab[i] > tab[j])
                            {
                            double temp = tab[i];
                            tab[i] = tab[j];
                            tab[j] = temp;

                            }   
                        }
                  }
                return tab;



            }

            Console.WriteLine("podaj długość ciągu: ");
            uint n = uint.Parse(Console.ReadLine());
            double[] tab = new double[n];
            Console.WriteLine("Podaj elementy tablicy: ");

        
            for(int i=0; i<n; i++)
            {
                tab[i] = uint.Parse(Console.ReadLine());
            }

            Console.WriteLine("Posortowana tablica: ");
            for(int i=0; i <n; i++)
            {
                Console.WriteLine(sortowanie(tab)[i]);
            }
            
            

            


        }

    }   

    
}
