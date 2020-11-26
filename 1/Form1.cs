using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Move(object sender, EventArgs e)
        {
            MessageBox.Show("Moved!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            MessageBox.Show("Activated!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Loaded!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Visible Changed!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            MessageBox.Show("Shown!!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            MessageBox.Show("Paint!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Closed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Closed!!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Closing!!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            MessageBox.Show("Deactivated!!!", "THONG BAO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



    }
}
