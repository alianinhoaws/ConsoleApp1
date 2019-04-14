using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[,] arr = new int[3, 2]
            { {2,5} , {21,4}, {3,11}

            };


            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine(arr [i, j]);
                    Console.Write(" ");
                }
                {
                    Console.ReadKey();
                }

            }
        }
    }
}



    
 
      
     
    