using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            {
                nums.Add(73);
                nums.Add(22);
            }
           
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i]);
                Console.Write(" ");
            }
            nums.RemoveAt(0);
            Console.Write("\n");

            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write(nums[i]);
                            }

            Console.ReadKey();
        }

    }
}



    
 
      
     
    