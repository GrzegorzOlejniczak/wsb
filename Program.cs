using System;

namespace kolkokrzyzyk
{
    class Program
    {
        static void Main(string[] args)
        {
            //zad1
            //int a;
            //Console.Write("Podaj liczbe: ");
            //a = int.Parse(Console.ReadLine());


            //if (a % 2 == 0)
            //{
            //    Console.WriteLine("liczba jest parzysta");
            //}
            //else
            //{
            //    Console.Write("Liczba nie jest parzysta");
            //}


            //zad2

            //int a, b;
            //char znak = ' ';

            //Console.Write("Podaj a: ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Operacja: ");
            //znak = char.Parse(Console.ReadLine());
            //Console.Write("Podaj b: ");
            //b = int.Parse(Console.ReadLine());

            //switch (znak)
            //{
            //    case '+':
            //        Console.WriteLine(a + b);
            //        break;
            //    case '-':
            //        Console.WriteLine(a - b);
            //        break;
            //    case '*':
            //        Console.WriteLine(a * b);
            //        break;
            //    case '/':
            //        Console.WriteLine(a / b);
            //        break;
            //}

            
            
            
            int a, b,c;
            Console.Write("podaj liczbe 1: ");
            a = int.Parse(Console.ReadLine());


            Console.Write("podaj liczbe 2: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("podaj liczbe 3: ");
            c = int.Parse(Console.ReadLine());

            int[] tab = { a, b, c };


            Array.Sort(tab);

            for(int i=0; i<tab.Length; i++)
            {
                Console.Write(tab[i]+" ");
            }













        }
    }
}
