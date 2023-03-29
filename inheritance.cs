using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    public class inheritance
    {
        int maxspeed;
        public void maxSpeed(int s)
        {
            this.maxspeed = s;
            Console.WriteLine("car class - max speed" + s);
        }

        public void ABS()
        {
            Console.WriteLine("abs is applied in car class");
        }
    }


    public class volvo : inheritance
    {
        public void test()
        {
            Console.WriteLine("in volvo class");

        }

        public void ABS()
        {
            Console.WriteLine("ABS applied in volvo class");
        }
    }

    public class volvoSports : volvo 
    {
     
        public void sportsCar()
        {
            Console.WriteLine("volvo sports car");
        }
    
    
    }
}
