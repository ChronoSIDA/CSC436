using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Paid2Play
{

    class Account : SignInPage

    {



        public string getName()
        {
           
            return Properties.Settings.Default.user; 
        }

        public decimal getCredits(string userName)
        {
            decimal x = 0;
            mysql z = new mysql();
            z.connect();
            x = z.getCredits(userName);
            return x;

        }
        public void setPassword(string user, string pass)
        {
            mysql z = new mysql();
            z.connect();
            z.setPassword(user, pass);

        }
        public void setCredits(string user, decimal amount)
        {
            mysql z = new mysql();
            z.connect();
            amount += z.getCredits(user);
            z.setCredits(user, amount);

        }




    }
}
