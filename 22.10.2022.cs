﻿using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            //while (a != b)
            //{
            //    if (a > b) a -= b;
            //    else b -= a;
            //}

            //zad5
            //double a, b, c, x,y;
            //Console.Write("Podaj a: ");
            //a= double.Parse(Console.ReadLine());
            //Console.Write("Podaj b: ");
            //b = double.Parse(Console.ReadLine());
            //Console.Write("Podaj c: ");
            //c = double.Parse(Console.ReadLine());
            //Console.Write("Podaj x: ");
            //x = double.Parse(Console.ReadLine());


            //y = a * Math.Pow(x, 2)+b*x+c;
            //Console.Write("Wartość funkcji kwadratowej wynosi: " + y);


            //___________________________________________________________________

            //zad7
            //float x;
            //Console.Write("Podaj liczbę: ");
            //x = float.Parse(Console.ReadLine());

            //Console.Write(x < 0 ? Math.Ceiling(x): Console.Write(Math.Floor(x)));
            //if (x > 0)
            //{
            //Console.Write(Math.Floor(x));

            //}
            //else
            //{
            //    Console.Write(Math.Ceiling(x));
            //}

            //Console.WriteLine();


            //Console.Write(Math.Truncate(x));
            //Console.Write((int)a);
            //int b = 0;
            //while (b <= x)
            //{
            //    b += 1;

            //}
            //Console.Write(b - 1);


            //___________________________________________________________________

            // int bok;
            //Console.Write("Podaj długość boku: ");
            //bok = int.Parse(Console.ReadLine());

            for (int j = 0; j <= 9; j++){

                    for (int i = 0; i <= 9; i++)
                    {
                
                        Console.Write("*");

                    }
                Console.WriteLine();
            }


            Console.WriteLine();


            for(int b=0; b<10; b++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for(int z = 0; z<10; z++)
            {


            for (int c = 0; c < 10; c++)
            {
                if (c == 0) {
                    Console.Write("*");
                    }
                else if (c == 9) {
                    Console.Write("*");
                }
                else {
                    Console.Write(" ");
                }
            }
                Console.WriteLine();

            }
            for (int b = 0; b < 10; b++)
            {
                Console.Write("*");
            }









        }
    }
}
