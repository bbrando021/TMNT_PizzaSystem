using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class FoodFactory
    {


        public TurtleTime getFood(String foodType)
        {
            if (foodType == null)
            {
                return null;
            }
            if (foodType.Equals("Pizza"))
            {
                return new Pizza();

            }
            else if (foodType.Equals("Fries"))
            {
                return new Fries();

            }
            else if (foodType.Equals("Breadsticks"))
            {
                return new Breadstick();
            }


            return null;
        }


    }
}
