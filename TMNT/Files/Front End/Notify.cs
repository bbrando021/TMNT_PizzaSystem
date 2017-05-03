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
    public partial class Notify : Form
    {
        public static Label delivery;
        public Notify()
        {
            InitializeComponent();
            //Color colorCus = System.Drawing.ColorTranslator.FromHtml("#006491");
            //this.BackColor = colorCus;
            delivery = label2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
