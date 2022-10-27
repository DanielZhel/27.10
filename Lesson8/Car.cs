using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    public abstract class Car : IVIhicle
    {
       
        public Car(int fuel, int cons)
        {
            cons = ;
            fuel = ;
            return;


        }

        public void Drive(int distance)
        {
            Console.WriteLine("Enter amount of the fuel");
            
            int amount = Convert.ToInt16(Console.ReadLine());
            if (Refuel(amount) == true)
            {
                Console.WriteLine("The car is driving now");
            }
            else
                Console.WriteLine("No fuel");
            

        }
        public bool Refuel(int amount)
        {
            bool refuel = true;
            if (amount > 0)
            {
               refuel = true;
            }
            return refuel;

        }

    }
}
   

