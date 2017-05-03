using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class GreatLakesProvolone : GreatLakesCheese, ProvoloneIF
    {
        public GreatLakesProvolone()
        {
            price = 2.50;
            name = "Great Lakes Provolone";
        }
    }
}
