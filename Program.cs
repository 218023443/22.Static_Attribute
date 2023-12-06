using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Static_Attribute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Movie movie1 = new Movie("Titanic", "Jim", "PG-13");
            Movie movie2 = new Movie("Unreleased", "Evan", "PG");
            Console.WriteLine(movie1.Rating);
            Console.WriteLine(movie2.Rating);
            Console.ReadLine(); 
        }
    }
}
