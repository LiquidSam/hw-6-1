using System;

namespace string2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter poem, split strings with ','");
            string text = Console.ReadLine();

            string newtext = text.Replace('о', 'а');
            string newtext1 =newtext.Replace("л", "ль");
            string newtext2 =newtext1.Replace("ть", "т");
            

            String[] poem = newtext2.Split(new char[] { ',' });

            foreach (string s in poem)
            {
                Console.WriteLine(s);
            }
        }
    }
}
