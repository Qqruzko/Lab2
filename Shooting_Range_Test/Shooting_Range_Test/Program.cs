using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shooting_Range
{
    public class Counter
    {
        public void Shot() 
        {
            Console.WriteLine("Enter X coord");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y coord");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Entered coords: x={0}, y={1}", x, y);
            double katet_a = 0 + x;
            double katet_b = 0 + y;
            double gipotenuza = Math.Sqrt((Math.Pow(katet_a, 2)) + (Math.Pow(katet_b, 2)));
           
            if (gipotenuza < 1)
            {
                Console.WriteLine("You gain 10 pts");
            }
            else
            if (gipotenuza < 2)
            {
                Console.WriteLine("You gain 5 pts");
            }
            else
                if (gipotenuza < 3)
            {
                Console.WriteLine("You gain 1 pts");
            }
            else
                Console.WriteLine("You gain nothing");
            Console.ReadLine();
            Console.WriteLine("You gain nothing");
            Shot();
        }
    }
    class Program
    {
        
        
            
        
        static void Main(string[] args)
        {
            Counter a = new Counter();
            a.Shot();
            
        }
    }
}
