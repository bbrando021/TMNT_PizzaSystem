using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class GreatLakesCheese : ProxyCheese, CheeseIF
    {
        public GreatLakesCheese()
        {
            price = 2.00;
            name = "Great Lakes Cheese";
        }
    }
}
