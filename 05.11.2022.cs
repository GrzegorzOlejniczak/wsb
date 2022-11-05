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
            











        }
    }
}
