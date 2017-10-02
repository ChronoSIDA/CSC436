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
    public partial class apps : Form
    {
        public apps()
        {
            InitializeComponent();
        }
        
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu x = new menu();
            x.home();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu x = new menu();
            x.profile();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu x = new menu();
            x.signin();
        }
    }
}
