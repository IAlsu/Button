using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //no need for code
        }

        private void button1_MouseMove_1(object sender, MouseEventArgs e)
        {
            button1.Location = new Point(rnd.Next(this.Width - button1.Width), rnd.Next(this.Height - button1.Height));
        }
    }
}

