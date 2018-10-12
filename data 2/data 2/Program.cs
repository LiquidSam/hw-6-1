using System;

namespace data_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[3, 3] {
                { 34, 64, 98 },
                { 31, 65, 43 },
                { 51, 23, 72 }
            };

            for (int i = 0; i < 3; i++)
            {
                int max = data[i, 0];
                for (int j = 0; j < 3; j++)
                {
                    if (data[i, j] > max)
                        max = data[i, j];

                }
                Console.WriteLine("max:{0}", max);

            }
        }
    }
}