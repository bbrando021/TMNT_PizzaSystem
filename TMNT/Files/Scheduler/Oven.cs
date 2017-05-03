using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    class Oven 
    {
        public static object o = new object();
        public static int inUse = 0;
        TurtleTime food;
        string orderName;
        ListBox list;

        public Oven(TurtleTime food, string orderName, ListBox list)
        {
            this.food = food;
            this.orderName = orderName;
            this.list = list;
        }
        public void cook()
        {
            ListBox tempList = list;
            TurtleTime tempT = food;
            string tempOrd = orderName;

            lock (Oven.o)
            {
                while (inUse == 1) {
                    Monitor.Wait(o);
                }
                inUse = 1;
                Console.WriteLine("COOKING: " + tempOrd);
                inOven(tempOrd, tempT, tempList);
                Console.WriteLine("DONE : " + tempOrd);
                inUse = 0;
            }
        }
        private void inOven(string order, TurtleTime food, ListBox list)
        {
            Thread.Sleep(10000);
            OrderQueue.orderName.Remove(order);
            OrderQueue.orderQueue.Remove(food);


            list.Invoke(new MethodInvoker(delegate ()
            {
                list.Items.Clear();

                for (int i = 0; i < OrderQueue.orderName.Count; i++)
                {
                    list.Items.Add("");
                    list.Items.Add((OrderQueue.orderName[i]) + " - " + (OrderQueue.orderQueue[i].name));
                }
                Notify n = new Notify();
                n.Visible = true;
                Notify.delivery.Text = (order + " your " + (food.name) + " has been cooked and is on its way!");
            }));
            if (OrderQueue.orderName.Count == 0)
            {
                Ordering.removeOrderScreen();
            }
        }

    }
}
