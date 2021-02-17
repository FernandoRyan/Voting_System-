using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting_System1
{
    public partial class voteNow : Form
    {
        public voteNow()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "You are eligible for voting";
            string title = "Message";
            MessageBox.Show(message, title);

            Vote obj1 = new Vote();
            obj1.Show();
            this.Hide();
        }
    }
}
