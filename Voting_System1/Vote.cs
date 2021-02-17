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
    public partial class Vote : Form
    {
        public Vote()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            voteNow obj1 = new voteNow();
            obj1.Show();
            this.Hide();
        }
    }
}
