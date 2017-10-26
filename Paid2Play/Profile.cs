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

        private void profile_Load(object sender, EventArgs e)
        {
            Account x = new Account();
            username.Text = x.getName();
            string uname = x.getName(); 
            credits.Text = ("wallet: $ " + x.getCredits(uname).ToString());

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "enter new password";
            cpwordbox.Show();
            enter.Show();
        }

        private void enter_Click(object sender, EventArgs e)
        {
            Account x = new Account();
            string pass = cpwordbox.Text;
            string user = username.Text;
            x.setPassword(user, pass);
            cpwordbox.Hide();
            enter.Hide();
            label1.Text = "click here to change password";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Account x = new Account();
            string user = username.Text;
            string y = addbox.Text;
            decimal amount = System.Convert.ToDecimal(y);
            x.setCredits(user, amount);
            credits.Text = ("wallet: $ " + x.getCredits(user).ToString());
        }
    }
}
