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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ADlog1 obj1 = new ADlog1();
            obj1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VoteReg obj1 = new VoteReg();
            obj1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CandidateReg obj1 = new CandidateReg();
            obj1.Show();
            this.Hide();
        }
    }
}
