using System;

namespace ConsoleApp1
{
   /*
    class Program
    {
        static void Main ()
        {
            int x;
            double y, z;
            x = 12;
            y = 33;
            x = (int)y;
            z = x + y;
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
            Console.Write( "not at new line   " );
            Console.WriteLine("Line " + z);
            Console.ReadKey();
        }
    }
    class ifDemo
    {
        static void Main()
    {
            int a, b, c;
            a = 2;
            b = 3;
            if (a < b) Console.WriteLine(" a less then b");
            else;
            Console.WriteLine("no");
    }
  */
    class forDemo
    {
        static void Main() { 
    
            decimal price, discont;
            price = 155.33m;

            for (discont = 5; discont > 0; discont--)
            {
                price = price - (price-discont);
                Console.WriteLine("this is price for next piar " + price);
            }
           
    

        }
    }
}
    