using System;

namespace data3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] data = new int[5] {5,8,4,7,3};
            Array.Sort(data); 

            for (int i = 0; i < data.Length; i++)               
                Console.Write(" " + data[i]);
            Console.ReadKey();
        }
    }
}
