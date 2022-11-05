using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char x;


            Console.Write("Podaj pierwszą liczbę: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Podaj znak operacji: ");
            x = char.Parse(Console.ReadLine());
            Console.Write("Podaj drugą liczbę: ");
            b = int.Parse(Console.ReadLine());

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
                    Console.WriteLine(a / b);

                    break;
            }






        }
    }
}
