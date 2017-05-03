using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pizza
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
            Console.WriteLine(Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory()))+ @"\tmnt.swf");
            axShockwaveFlash1.Movie = Path.GetDirectoryName(Path.GetDirectoryName(System.IO.Directory.GetCurrentDirectory())) + @"\tmnt.swf";
            axShockwaveFlash1.Play();
            STOP.BackColor = Color.Transparent;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axShockwaveFlash1.Stop();
            this.Dispose();
        }

        private void STOP_MouseUp(object sender, MouseEventArgs e)
        {
            axShockwaveFlash1.Stop();
            this.Dispose();
        }

        private void STOP_Click(object sender, EventArgs e)
        {

        }
    }
}
