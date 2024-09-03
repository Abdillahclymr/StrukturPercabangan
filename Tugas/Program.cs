using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Silahkan pilih senjata");
            string weapon = Console.ReadLine();
            if (weapon == "Arrow")
            {
                for (int i = 1; i <= 1; i++)
                {
                    Console.WriteLine("Damage +1");
                }
            }else if (weapon == "Fist")
            {
                for (int i = 1; i <= 2; i++)
                {
                    Console.WriteLine("Damage +1");
                }
            }else if (weapon == "Sword")
            {
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine("Damage +1");
                }
            }else if (weapon == "Gun")
            {
                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine("Damage +1");
                }
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
