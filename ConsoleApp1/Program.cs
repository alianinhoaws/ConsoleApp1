using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Cars
    {
        public int wheels;
        private float speed;
        protected bool isWorking = true;
    
        public void GetValues()
        {
            Console.WriteLine("Car speed " + this.speed + ", car is working "
                + this.isWorking + " Wheels " + this.wheels);
        }

        public Cars (int wheels, float speed, bool isWorking)
        {
            this.wheels = wheels;
            this.speed = speed;
            this.isWorking = isWorking;

        }

        public Cars() // перегрузка для снятия ощибки
        {

        }

        class MainClass
        {
            public static void Main (string[] args)
            {
                Cars Audi = new Cars(4, 223.4f, true);
                Audi.GetValues();
                Cars Volvo = new Cars(6,180.4f,false);
                Volvo.GetValues();
                Cars Renault = new Cars();
                Renault.GetValues();
                Console.ReadKey();
            }
        }
    }
}



    
 
      
     
    