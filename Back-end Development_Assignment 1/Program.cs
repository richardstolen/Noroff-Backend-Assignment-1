using Back_end_Development_Assignment_1.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_end_Development_Assignment_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mage mage = new Mage("name");
            Console.WriteLine(mage);
        }
    }
}
