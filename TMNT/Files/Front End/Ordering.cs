using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace pizza
{
    public partial class Ordering : Form
    {
        public static Panel displayP;
        public static ListBox listBox;
        System.Media.SoundPlayer main;
        public static Label timeLabel;
        public Ordering()
        {
            InitializeComponent();
            main = new System.Media.SoundPlayer(Properties.Resources.Teenage_Mutant_Ninja_Turtles_Theme);
            main.Play();
            panel3.Visible = false;
            Color colorCus = System.Drawing.ColorTranslator.FromHtml("#006491");
            panel1.BackColor = colorCus;
            displayP = panel3;
            timeLabel = label4;
            listBox = listBox1;
            //Notify n = new Notify();
            //n.Visible = true;
        }

        public static void populateOrders()
        {
            listBox.Items.Clear();
            for (int i = OrderQueue.orderName.Count - 1; i < OrderQueue.orderName.Count; i++)
            {
                TurtleTime t = OrderQueue.orderQueue[i];
                string oN = OrderQueue.orderName[i];
                Oven o = new Oven(t, oN,listBox);
                Thread oThread = new Thread(new ThreadStart(o.cook));
                oThread.Start();
                //Thread t = new Thread(new ThreadStart(o.cook(t,oN)));
                for (int j = 0; j < OrderQueue.orderName.Count; j++)
                {
                    listBox.Items.Add("");
                    listBox.Items.Add((OrderQueue.orderName[j]) + " - " + (OrderQueue.orderQueue[j].name));
                }
                //timeLabel.Text = ((OrderQueue.orderName.Count * 15).ToString() + "s");
            }
        }
        public static void displayOrders()
        {
            
            for (int i = 0; i<OrderQueue.orderName.Count; i++)
            {
                listBox.Items.Add("HELLO");
                listBox.Items.Add((OrderQueue.orderName[i]) + " - " + (OrderQueue.orderQueue[i].name));
            }

            //timeLabel.Text = ((OrderQueue.orderName.Count* 15).ToString() + "s");
       }

        public static void removeOrderScreen()
        {
            displayP.Invoke(new MethodInvoker(delegate ()
            {
                displayP.Visible = false;
            }));
        }
        private void Ordering_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void Ordering_MouseUp(object sender, MouseEventArgs e)
        {
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            Game g = new Game();
            g.Visible = true;
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox6.BackgroundImage = Properties.Resources.pizzaOrderClick;
          
        }

        private void pictureBox6_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox6.BackgroundImage = Properties.Resources.pizzaOrder;
            //webBrowser1 w = new webBrowser1();
            PizzaOrder p = new PizzaOrder();
            p.Visible = true;
            p.initFood("Pizza");
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox7.BackgroundImage = Properties.Resources.BreadOrderClick;
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox7.BackgroundImage = Properties.Resources.BreadOrder;
            PizzaOrder p = new PizzaOrder();
            p.Visible = true;
            p.initFood("Breadsticks");
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox8.BackgroundImage = Properties.Resources.FriesOrderClick;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox8.BackgroundImage = Properties.Resources.FriesOrder;
            PizzaOrder p = new PizzaOrder();
            p.Visible = true;
            p.initFood("Fries");

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Ordering_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
