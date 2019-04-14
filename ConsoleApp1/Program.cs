using System;

namespace ConsoleApp1
{ 
    class MainClass
    {
        public static void Main(string[] args)
        {
            int [] arr = new int [5];
            arr[0] = 54;
            arr[4] = 33;
            for (int i=0;i<arr.Length;i++)
            {
                Console.Write (arr [i]);
                Console.Write(" ");
            }
            
            Console.ReadKey();
            }
        }
}


    
 
      
     
    