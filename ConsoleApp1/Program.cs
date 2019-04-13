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
            sbyte s = (sbyte)z;
            string str0 = null;
            string str1 = "some thing";
            string str2 = "some thing";
            string str3 = str1 + str0 + str2;
            Console.WriteLine(str3); 
            Console.WriteLine(z);
            Console.ReadKey();
        }
    }
}
    