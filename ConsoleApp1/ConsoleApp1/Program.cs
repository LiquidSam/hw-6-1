using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[6];
            int i = 0;
            while (i < 6)
            {
                Console.WriteLine("Введите элемент массива");

                data[i] = Int16.Parse(Console.ReadLine());
                Console.WriteLine();
                i++;
            }

            for (i = 0; i < 6; i = i + 1)
                Console.WriteLine("Элемент[" + i + "]: " + data[i]);
            Console.ReadLine();
        }
    }
}
    

