using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xEngine
{
    public partial class Exit : Form
    {
        public Exit()
        {
            InitializeComponent();
            this.TopMost = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Exit_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
