using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class GreatLakesMozzarella : GreatLakesCheese, MozzarellaIF
    {
        public GreatLakesMozzarella()
        {
            price = 3.50;
            name = "Great Lakes Mozzarella";
        }
    }
}
