using System;

namespace ConsoleApp1
{ 
    class MainClass
    {
        public static void Main(string[] args)
        {
            double a;
            bool isTrue = true;
            a=Convert.ToDouble (Console.ReadLine ());
            if (a > 10f)
            {
                Console.Write("A bigger then 10");
            }
            else if (a < 10f && a > 0)
            {
                Console.Write("a" + isTrue);
            }
            else if (a < 10f && a < 0)
            {
                Console.Write("BAD");
            }
          
            Console.WriteLine("Res  " + a);
            Console.ReadKey();
            }
        }
}


    
 
      
     
    