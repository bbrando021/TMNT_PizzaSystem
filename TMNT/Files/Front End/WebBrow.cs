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
    public partial class webBrowser1 : Form
    {
        public webBrowser1()
        {
            InitializeComponent();
            //webBrowser1.Navigate("https://www.dominos.com/en/pages/order/#/locations/search/?type=Delivery");
            Color colorCus = System.Drawing.ColorTranslator.FromHtml("#006491");
            pictureBox1.BackColor = colorCus;
            panel1.BackColor = colorCus;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
