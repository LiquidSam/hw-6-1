using System;

namespace string1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter string");
            string text = Console.ReadLine();
            int c = text.Length;
            if (c>13)
            {
                string a = "...";
                string t1 = text.Remove(13);
                string t3 = t1 + a;
                Console.WriteLine(t3);
            }
            else
            {
                Console.WriteLine(text);
            }
            
        }
    }
}
