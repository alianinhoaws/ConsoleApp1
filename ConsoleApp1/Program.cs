using System;

namespace ConsoleApp1
{ 
    class MainClass
    {
        public static void Main(string[] args)
        {
            int a, b;
            a=Convert.ToInt32(Console.ReadLine());
            switch (a) 
                {
                case 1:
                    b = 45;
                    Console.Write(b);
                    break;
                case 2:
                    b = 55;
                    Console.Write(b);
                    break;
                case 3:
                    b = 65;
                    Console.Write(b);
                    break;
                default:
                    b = 0;      
                    Console.Write(b);
                    break;

            }
            Console.ReadKey();
            }
        }
}


    
 
      
     
    