using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Cars
    {
        public int wheels = 4;
        private float speed;
        protected bool isWorking = true;
    

    public void SetValues(float speed, bool isWorking)
    {
        this.speed = speed;
        this.isWorking = isWorking;

    }
        public void GetValues()
        {
            Console.WriteLine("Car speed " + this.speed + ", car is working "
                + this.isWorking + " Wheels " + this.wheels);
        }


        class MainClass
        {
            public static void Main (string[] args)
            {
                Cars Audi = new Cars();

                Audi.SetValues(223.3f, true);
                Audi.GetValues ();
                Cars Volvo = new Cars();
             
                Volvo.wheels = 6;
                Volvo.SetValues(180.3f, false);
                Volvo.GetValues();
               
                Console.ReadKey();
            }
        }
    }
}



    
 
      
     
    