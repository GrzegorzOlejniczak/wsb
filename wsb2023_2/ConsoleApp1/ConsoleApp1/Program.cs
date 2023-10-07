using System;
using ConsoleApp1;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dom d = new Dom();
            d.Adres = "ul.Testpwa 2";
            Console.WriteLine(d.Adres);
        }
    }
}
