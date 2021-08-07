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
    public partial class disabled : Form
    {
        public disabled()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            this.Opacity = 0;
        }

        private void disabled_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            

        }
        public void exitA()
        {

        }
    }
}
