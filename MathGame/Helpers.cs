using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class Helpers
    {
        internal static string GetName()
        {
            Console.WriteLine("Please enter your name: ");
            string name = Console.ReadLine();

            while(string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name cannot be empty.");
                Console.WriteLine("Please enter your name: ");
                name = Console.ReadLine();
            }
            return name;
        }
    }
}
