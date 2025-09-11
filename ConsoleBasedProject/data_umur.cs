using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBasedProject
{
    internal class data_umur
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Masukkan nama Anda: ");
            string nama = Console.ReadLine();

            Console.WriteLine("Masukkan nama Anda: ");
            int umur = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Halo " + nama + ", umur anda " + umur + " tahun");
            Console.ReadLine();
        }
    }
}
