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
    public partial class SignUpMain : Form
    {
        public SignUpMain()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {

            mysql z = new mysql();
            z.connect();
            string user = createUsr.Text;
            string pass = CreatePWD.Text;
            if (user != "")
            {
                z.addUser(user, pass);
                this.Hide();
                SignInMain x = new SignInMain();
                string userName = user;
                Properties.Settings.Default.user = userName;
                x.Show();
            }
            else
            {
                MessageBox.Show("Cannot leave values as empty");
                z.CloseConnect();


            }
        }
    }
}
