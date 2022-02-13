using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Address a = new Address();
            a.Index = 08300;
            a.Name = "Ukraine";
            a.Name1 = "Kiev";
            a.Name2 = "Shevchenka";
            a.House = 228;
            a.Apartment = 17;
            Console.WriteLine($"index:{a.Index}, country:{a.Name}, city:{a.Name1}, street:{a.Name2}, house:{a.House}, apartment:{a.Apartment},");


        }




    }
}
