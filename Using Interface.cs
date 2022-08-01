using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Purpose
{
    interface car
    {
        float getMileage();
    }
    class SUV : car
    {
        public float getMileage()
        {
            float rogers = 50;
            return rogers;
        }
    }
    class Sedan : car
    {
        public float getMileage()
        {
            float honda = 40;
            return honda;
            
        }
   
    }
    class HatchBack : car
    {
        public float getMileage()
        {
            float suzuki = 60;
            return suzuki;
        }
    }

   class city : Sedan
    {
        public float getMileage()
        {
            float city = 20;
            return city;
        }
    }
    class Maruti : Sedan
    {
        public float getMileage()
        {
            float Maruti = 30;
            return Maruti;
        }
    }
    class Toyota : Sedan
    {
        public float getMileage()
        {
            float Toyota = 10;
            return Toyota;
        }
    }

    class Program
    {
        public static void Main(String[] args)
        {
            
            SUV car1 = new SUV();
            car1.getMileage();
            Sedan car2 = new Sedan();
            HatchBack car3 = new HatchBack();
            Console.WriteLine("Rogers Mileage : " + car1.getMileage());
            Console.WriteLine("Honda Mileage : " + car2.getMileage());
            Console.WriteLine("Suzuki Mileage : " + car3.getMileage());

            if (car1.getMileage() < 50){
                Console.WriteLine("Normal Condition");
            }
            else
            {
                Console.WriteLine(" Problem");
            }
            Console.ReadKey();
        }
    }
}
