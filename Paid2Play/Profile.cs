using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paid2Play
{
    public partial class profile : Form
    {
        public profile()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu x = new menu();
            x.home();
        }

        private void appsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu x = new menu();
            x.apps();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu x = new menu();
            x.signin();
        }
    }
}
