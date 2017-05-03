using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class Breadstick : TurtleTime, FoodIF
    {
        public Breadstick()
        {
            createFood();
            name = "BreadSticks";
        }

        public void createFood()
        {
            Console.WriteLine("You have created Breadsticks!");
        }
    }
}
