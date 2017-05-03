using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class Pizza : TurtleTime, FoodIF
    {

        public Pizza()
        {
            createFood();
            name = "Pizza";
        }

        public void createFood()
        {
            Console.WriteLine("You have created a pizza!");

        }
    }
}
