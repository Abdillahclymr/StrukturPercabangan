using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nama;
            Console.WriteLine("Tuliskan nama panggilan");
            nama = Console.ReadLine();

            if (nama == "Abdillah".ToLower())
            {
                Console.WriteLine("Abdillah Hakim");
                Console.WriteLine("15 Tahun");
                Console.WriteLine("Maos, Cilacap");
            }
            else
            {
                Console.WriteLine("Ini bukan nama saya");
            }
        }
    }
}
