using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 5;
            int y = 6;
            int z = x + y;
            x = 12;
            y = 33;
            x = y;
            string str0 = null;
            string str1 = "some thing";
            string str2 = "some thing";
            string str3 = str1 + str0 + str2;
            string str4 = Convert.ToString(x);
            float F = 3.5f;
            string strR = Console.ReadLine ();
            int zd = Convert.ToInt32(str0);
            int f = (int)F;
            Console.WriteLine(F);
            Console.WriteLine();
            Console.WriteLine(str4); 
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
    