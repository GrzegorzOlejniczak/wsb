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



            uint liczbaWPrzedziale(uint[] tab, int a, int b)
            {
                uint licznik = 0;
                foreach(uint liczba in tab)
                {
                    if (liczba >= a && liczba <= b)
                    {
                        return liczba;
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
                

            }


            Console.WriteLine("Podaj a: ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj b; ");
            int y = int.Parse(Console.ReadLine());



            Console.WriteLine(liczbaWPrzedziale(tab, x, y));



            


        }

    }   

    
}
