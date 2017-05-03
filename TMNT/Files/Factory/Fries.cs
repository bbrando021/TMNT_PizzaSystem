using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class Fries : TurtleTime, FoodIF
    {

        public Fries()
        {
            createFood();
            name = "Fries";
        }
        public void createFood()
        {
            Console.WriteLine("You have created Fries!");
        }
    }
}
