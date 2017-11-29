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
    public partial class SignInMain : Form
    {
        public SignInMain()
        {
            InitializeComponent();
        }

        
        private void LoginButton_Click(object sender, EventArgs e)
        {
  

            mysql z = new mysql();
            z.connect();
            string user = unText.Text;
            string pass = pwdText.Text;
            bool check = z.verifyUser(user, pass);
            if (check == true)
            {
                this.Hide();
                Home x = new Home();
                string userName = user;
                Properties.Settings.Default.user = userName;
                x.Show();
            }
            else
            {
                MessageBox.Show("invalid username or password");
            }


        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpMain x = new SignUpMain();
            x.Show();


        }
    }
}
