using Paid2Play.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

        private void button1_Click(object sender, EventArgs e)
        {
           
            
   


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void apps_Load(object sender, EventArgs e)
        {
            //images
            var Asteroids = Resources.asteroid;
            var rogue = Resources.rogue;
            var assistant = Resources.assistant;
            var trump = Resources.trump;
            var walkie = Resources.walkie;
            var cardshark = Resources.cardshark;
          

            mysql conn = new mysql();
            conn.connect();
            string str = "";
            for (int i = 1; i < 7; i++)
            {
                str += conn.getGame(i);
            }
            string[] broken = new string[] { };
            broken = str.Split('1');
            dataGridView1.Rows.Add(new object[] { broken[0], broken[1], broken[2], Asteroids });
            dataGridView1.Rows.Add(new object[] { broken[3], broken[4], broken[5], rogue});
            dataGridView1.Rows.Add(new object[] { broken[6], broken[7], broken[8], assistant });
            dataGridView1.Rows.Add(new object[] { broken[9], broken[10], broken[11], walkie });
            dataGridView1.Rows.Add(new object[] { broken[12], broken[13], broken[14], cardshark });
            dataGridView1.Rows.Add(new object[] { broken[15], broken[16], broken[17], trump });
            conn.CloseConnect();
           


        }

        private void gameClick(String name)
        {
            mysql conn = new mysql();
            Process proc = new Process();
            proc.StartInfo.FileName = "C:\\Users\\ryano\\Desktop\\game\\" + name;
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
            Account x = new Account();
            string user = x.getName();
            string y = "1";
            decimal amount = System.Convert.ToDecimal(y);
            x.setCredits(user, amount);
            conn.connect();
            DateTime date = DateTime.Now;
            conn.addActivity(name, date.ToString());
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = dataGridView1.CurrentRow.Index;
            int columnIndex = 0;
            String game = dataGridView1.Rows[rowIndex].Cells[columnIndex].Value.ToString();

            gameClick(game);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //images
            var Asteroids = Resources.asteroid;
            var rogue = Resources.rogue;
            var assistant = Resources.assistant;
            var trump = Resources.trump;
            var walkie = Resources.walkie;
            var cardshark = Resources.cardshark;
            Dictionary<string, object> images = new Dictionary<string,object>() { };
            images.Add("Asteroids", Asteroids);
            images.Add("Rogue", rogue);
            images.Add("Assistant", assistant);
            images.Add("Walkie", walkie);
            images.Add("CardShark", cardshark);
            images.Add("TrumpVs.Un", trump);

            mysql conn = new mysql();
            conn.connect();
            string str = "";
            str += conn.gameSearch(searchBox.Text);
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            string[] broken = new string[] { };
            broken = str.Split('1');
            dataGridView1.Rows.Add(new object[] { broken[0], broken[1], broken[2], images[broken[0]]});
            conn.CloseConnect();

        }
    }
}
