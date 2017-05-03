using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class PizzaOrder : Form
    {
        TurtleTime food;

        int show = 0;
        double cheesePrice = 0, crustPrice = 0, saucePrice = 0, topPrice = 0;
        string orderName;
        public PizzaOrder()
        {
            InitializeComponent();
            Color colorCus = System.Drawing.ColorTranslator.FromHtml("#006491");
            pictureBox1.BackColor = colorCus;
            panel1.BackColor = colorCus;
            //comboBox1.BackColor = colorCus;
            panel3.BackColor = colorCus;
        }

        public void initFood(string foods)
        {
            FoodFactory factory = new FoodFactory();
            food = factory.getFood(foods);
            label6.Text = foods;
            //if (foods.Equals("Pizza"))
            //{
            //    label1.Text = "      Crust";
            //    label6.Text = "Pizza";
            //    food = new Pizza();
            //}
            //else if (foods.Equals("Breadsticks"))
            //{
            //    label1.Text = "      Crust";
            //    label6.Text = "Calzone";
            //    food = new Breadstick();
            //}
            //else if (foods.Equals("Fries"))
            //{
            //    label1.Text = "Seasoning";
            //    label6.Text = "Fries";
            //    food = new Fries();
            //}
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                food.cheese = new ProxyCheese();
                food.cheese.setType(comboBox3.GetItemText(comboBox3.SelectedItem));
                cheesePrice = food.cheese.cheese.price;

                label10.Text = ("$" + (crustPrice + cheesePrice + saucePrice + topPrice + ((crustPrice + cheesePrice + saucePrice + topPrice) * 0.06)).ToString("#.00"));
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                if (comboBox2.SelectedIndex == 0)
                {
                    food.sauce = new Tomato();
                    saucePrice = food.sauce.price;
                }
                else
                {
                    food.sauce = new Alfredo();
                    saucePrice = food.sauce.price;
                }
                label10.Text = ("$" + (crustPrice + cheesePrice + saucePrice + topPrice + ((crustPrice + cheesePrice + saucePrice + topPrice) * 0.06)).ToString("#.00"));
            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked)
            {
                if (c.Text.Equals("Pepperoni"))
                {
                    food.toppings.Add(new Pepperoni());
                    topPrice += 2.00;
                }else if (c.Text.Equals("Sausage"))
                {
                    food.toppings.Add(new Sausage());
                    topPrice += 2.00;
                }
                else if (c.Text.Equals("Meatball"))
                {
                    food.toppings.Add(new Meatball());
                    topPrice += 2.00;
                }
                else if (c.Text.Equals("Bacon"))
                {
                    food.toppings.Add(new Bacon());
                    topPrice += 2.00;
                }
                else if (c.Text.Equals("Ham"))
                {
                    food.toppings.Add(new Ham());
                    topPrice += 2.00;
                }
                else if (c.Text.Equals("Chicken"))
                {
                    food.toppings.Add(new Chicken());
                    topPrice += 2.00;
                }

            }
            else
            {
                topPrice -= 2.00;
            }

            label10.Text = ("$" + (crustPrice + cheesePrice + saucePrice + topPrice + ((crustPrice + cheesePrice + saucePrice + topPrice) * 0.06)).ToString("#.00"));

        }

        private void checkBox2_Click_1(object sender, EventArgs e)
        {
            CheckBox c = (CheckBox)sender;
            if (c.Checked)
            {
                if (c.Text.Equals("Banana Peppers"))
                {
                    food.toppings.Add(new BananaPepper());
                    topPrice += 1.00;
                }
                else if (c.Text.Equals("Mushrooms"))
                {
                    food.toppings.Add(new Mushrooms());
                    topPrice += 1.00;
                }
                else if (c.Text.Equals("Onions"))
                {
                    food.toppings.Add(new Onions());
                    topPrice += 1.00;
                }
                else if (c.Text.Equals("Pineapple"))
                {
                    food.toppings.Add(new Pineapple());
                    topPrice += 1.00;
                }
                else if (c.Text.Equals("Hot Sauce"))
                {
                    food.toppings.Add(new HotSauce());
                    topPrice += 1.00;
                }
                else if (c.Text.Equals("BBQ Sauce"))
                {
                    food.toppings.Add(new BBQ());
                    topPrice += 1.00;
                }
            }
            else
            {
                topPrice -= 1.00;
            }

            label10.Text = ("$" + (crustPrice + cheesePrice + saucePrice + topPrice + ((crustPrice + cheesePrice + saucePrice + topPrice) * 0.06)).ToString("#.00"));

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (show % 2 == 0)
            {
                comboBox3.Visible = true;
                groupBox3.Height = 95;   
            }
            else
            {
                comboBox3.Visible = false;
                groupBox3.Height = 67;
            }
            food.cheese = new ProxyCheese();
            food.cheese.setType("No Cheese");
            cheesePrice = food.cheese.cheese.price;
            label10.Text = ("$" + (crustPrice + cheesePrice + saucePrice + topPrice + ((crustPrice + cheesePrice + saucePrice + topPrice) * 0.06)).ToString("#.00"));

            show++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int error = 0, cheese, sauce, crust;

            if(textBox1.Text.Equals("Order Name") || textBox1.Text.Equals(""))
            {
                label11.Visible = true;
                error = 1;
            }
            else
            {
                orderName = textBox1.Text;
                Console.WriteLine(orderName);
                label11.Visible = false;
            }
            crust = comboBox1.SelectedIndex;
            if (crust == -1)
            {
                label7.Visible = true;
                error = 1;
            }
            else
            {
                label7.Visible = false;

            }
            sauce = comboBox2.SelectedIndex;
            if (sauce == -1)
            {
                label8.Visible = true;
                error = 1;

            }
            else
            {
                label8.Visible = false;
            }
            if (!checkBox1.Checked)
            {
                cheese = comboBox3.SelectedIndex;
                if (cheese == -1)
                {
                    label9.Visible = true;
                    error = 1;
                }
                else
                {
                    label9.Visible = false;
                }
            }
            if(error == 1)
            {
                return;
            }
            else
            {
                //DO SOMETHING IN HERE FOR QUEUE AND THREAD
                this.Dispose();
                Ordering.displayP.Visible = true;
                OrderQueue.orderQueue.Add(food);
                OrderQueue.orderName.Add(orderName);
                Ordering.populateOrders();
            }
        }

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                if(comboBox1.SelectedIndex == 0)
                {
                    food.crust = new RegularCrust();
                }
                else if (comboBox1.SelectedIndex == 1)
                {
                    food.crust = new Cajun();

                }
                else
                {
                    food.crust = new BandG();
                }
                crustPrice = food.crust.price;
                label10.Text = ("$" + (crustPrice + cheesePrice + saucePrice + topPrice + ((crustPrice + cheesePrice + saucePrice + topPrice) * 0.06)).ToString("#.##"));

            }
        }
    }
}
