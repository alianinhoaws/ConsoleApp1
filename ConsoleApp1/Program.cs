using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    enum Models { AUDI, VOLVO, NISSAN, VOLKSWAGEN };


    class Cars
    {
        public int wheels;
        private float speed;
        protected bool isWorking = true;
        public Models model;
    
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
        class Truks : Cars
        {
            public int wage;
            public Truks(int wheels, float speed, bool isWorking, int wage) : base (wheels, speed, isWorking)
            {
                this.wage = wage;
            }
        }
      

        class MainClass
        {
            public static void Main (string[] args)
            {
                Truks Man = new Truks(8, 100.2f, true, 200);
                Man.GetValues();
                Console.WriteLine(Man.wage);
                Cars Audi = new Cars(4, 223.4f, true);
                Audi.model = Models.AUDI;
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



    
 
      
     
    