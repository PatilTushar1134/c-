using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication35
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }

        private void violetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Violet;
        }

        private void picture1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = imageList1.Images[0];
        }

        private void picture2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = imageList1.Images[1];
        }

        private void picture3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = imageList1.Images[2];
        }

        private void picture4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = imageList1.Images[3];
        }
    }
}
