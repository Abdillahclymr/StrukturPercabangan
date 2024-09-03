using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Percabangan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string item;
            item = Console.ReadLine();

            if (item == "Coin")
            {
                Console.WriteLine("Money +1");
            }
            else
            {
                Console.WriteLine("Money not change");
            }
        }
    }
}
