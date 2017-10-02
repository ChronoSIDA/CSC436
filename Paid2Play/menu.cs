using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paid2Play
{
    class menu
    {
        public static Form ActiveForm { get; }
        public void home()
        {
            Form y = Form.ActiveForm;
            y.Hide();
            Home x = new Home();
            x.Show();
        }
        public void profile()
        {
            Form y = Form.ActiveForm;
            y.Hide();
            profile x = new profile();
            x.Show();
        }
        public void apps()
        {
            Form y = Form.ActiveForm;
            y.Hide();
            apps x = new apps();
            x.Show();
        }
        public void signin()
        {
            Form y = Form.ActiveForm;
            y.Hide();
            SignInPage x = new SignInPage();
            x.Show();
        }
    }
}
