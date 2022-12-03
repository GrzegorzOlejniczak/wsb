POZMIENIAJCIE COŚ!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


using System;

namespace ConsoleApp22
{
    class Program
    {
        static void Main(string[] args)
        {


            //ZAD1
            uint a, b;
            Console.Write("Podaj a: ");
           
            

            while (true)
            {
                try
                {
                    a = uint.Parse(Console.ReadLine());
                    Console.Write("Podaj b: ");
                    b = uint.Parse(Console.ReadLine());
                    break;
                }
                catch (FormatException FormatException)
                {
                    Console.WriteLine("Podano nieprawidłowe dane wejściowe");
                    Console.Write("Podaj a: ");
                    
                }
                
            }

            for (int i =1; i<10; i++)
            {
                for(int j=1; j<10; j++)
                {

                Console.Write(i*a+j*b+" ");



                }
                    Console.WriteLine();

            }



            //ZAD2


            Random random = new Random();
            int randomNumber1;
            

            int suma = 0;
            int avg;
            int[] tab = new int[3];
            for(int i =0; i<20; i++)
            {
                if (i < 3)
                {


                    randomNumber1 = random.Next(1, 1001);
                    suma += randomNumber1;
                    Console.WriteLine(randomNumber1);


                }
                else
                {

                    avg = suma / tab.Length;
                    randomNumber1 = random.Next(1, 1001);
                    if (randomNumber1 > avg)
                    {
                        Console.WriteLine("Wylosowano "+randomNumber1 + " Ta liczba jest większa niż średnia z poprzednich trzech");
                    }
                    else
                    {
                        Console.WriteLine("Wylosowano " + randomNumber1);
                    }
                



                }
                



            }

        }
    }
}
