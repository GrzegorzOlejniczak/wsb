
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
                    Console.WriteLine(FormatException.Message);
                    ;
                    
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
