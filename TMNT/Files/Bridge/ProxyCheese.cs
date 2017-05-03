using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    class ProxyCheese : Cheese, CheeseIF
    {
        public Cheese cheese;

        public void setType(String cheese)
        {
            if (cheese.Equals("No Cheese"))
            {
                this.cheese = new NoCheese();
            }
            if (cheese.Equals("Cheese"))
            {
                this.cheese = new Cheese();
            }
            if (cheese.Equals("Provolone Cheese"))
            {
                this.cheese = new ProvoloneCheese();
            }
            if (cheese.Equals("Mozzarella Cheese"))
            {
                this.cheese = new MozzarellaCheese();
            }
            if (cheese.Equals("Kraft Cheese"))
            {
                this.cheese = new KraftCheese();
            }
            if (cheese.Equals("Kraft Provolone"))
            {
                this.cheese = new KraftProvolone();
            }
            if (cheese.Equals("Kraft Mozzarella"))
            {
                this.cheese = new KraftMozzarella();
            }
            if (cheese.Equals("Great Lakes Cheese"))
            {
                this.cheese = new GreatLakesCheese();
            }
            if (cheese.Equals("Great Lakes Provolone"))
            {
                this.cheese = new GreatLakesProvolone();
            }
            if (cheese.Equals("Great Lakes Mozzarella"))
            {
                this.cheese = new GreatLakesMozzarella();
            }
        }
    }
}
