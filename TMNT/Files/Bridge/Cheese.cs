using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class Cheese : AbsIngredients
    {
        public double price;
        public string name;

        public Cheese()
        {
            price = 1;
            name = "Cheese";
        }
    }
}
