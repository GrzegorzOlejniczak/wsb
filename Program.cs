using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            double a, b;
            char x;
            bool czyNieWlasciwyZnak = false;

            Console.Write("Podaj pierwszą liczbę: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Podaj znak operacji: ");
            x = char.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            b = double.Parse(Console.ReadLine());

            while (czyNieWlasciwyZnak == true)
            {

                switch (x)
                {
                    case '+':
                        Console.WriteLine(a + b);

                        break;
                    case '-':
                        Console.WriteLine(a - b);

                        break;
                    case '*':
                        Console.WriteLine(a * b);

                        break;

                    case '/':
                        if (b == 0)
                        {
                            Console.Write("Nie można dzielić przez 0");
                        }
                        else
                        {
                            Console.WriteLine(a / b);

                        }

                        break;
                    default:
                        {
                            Console.Write("Podano zły znak");
                            break;
                        }
                }
            }
            */



            //Liczba pierwsza
            /*
            int n;
            bool czyPierwsza = true;
            Console.Write("Podaj liczbę: ");
            n = int.Parse(Console.ReadLine());


            for(uint dzielnik = 2; dzielnik<=Math.Sqrt(n); dzielnik++)
            {
                if (n % dzielnik == 0)
                {
                    czyPierwsza = false;
                Console.Write("Liczba " + n + " jest liczbą złożoną");
                    break;

                }
            }
            if (czyPierwsza)
            {
                Console.Write("Liczba jest pierwsza");
            }

            */
            //suma szescianow liczb miedzu n a m 


            /*
            int n=0, m;
            int suma=0;
            Console.Write("Podaj n: ");
            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException FormatException)
                {
                    Console.WriteLine(FormatException.Message);
                }
                catch(OverflowException OverflowException)
                {
                    Console.WriteLine(OverflowException.Message);
                }
                catch(Exception)
                {
                    Console.WriteLine("Jakis inny wyjatek");
                }
            }

            Console.Write("Podaj m: ");
            m = int.Parse(Console.ReadLine());
            
            for(int i =n; i<=m; i++)
            {
                suma += (int)Math.Pow(i, 3);
            }

            Console.Write(suma);

            */

            int n;
            Console.Write("Podaj długość ciągu:");
            n = int.Parse(Console.ReadLine());



            double[] tab = new double[n];


            for(int i=0; i<n; i++)
            {
                Console.WriteLine("Podaj liczbe o indeksie " + i + " :");
                tab[i] = double.Parse(Console.ReadLine());
                
            }

            Console.WriteLine();
            Console.Write("Kolumna: ");
            for(int i =0; i<tab.Length; i++)
            {
                Console.WriteLine();
                Console.Write(tab[i]);
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Wiersz: ");
            for (int i = 0; i < tab.Length; i++)
            {
                
                Console.Write(tab[i]+",");
            }


            Console.WriteLine();
            Console.WriteLine();
            Console.Write("odwrotna kolejność: ");


            for(int i = tab.Length-1; i>=0; i--)
            {
                Console.Write(tab[i]+",");
            }
        }
    }
}
