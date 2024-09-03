using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perbandingan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int umur1 = int.Parse(Console.ReadLine());
            int umur2 = int.Parse(Console.ReadLine());

            if (umur1 < umur2)
            {
                Console.WriteLine("Jawaban benar");
            }
            else
            {
                Console.WriteLine("Salah");
            }
        }
    }
}
