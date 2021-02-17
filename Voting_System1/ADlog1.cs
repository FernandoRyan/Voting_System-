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
    public partial class ADlog1 : Form
    {
        public ADlog1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Register obj1 = new Register();
            obj1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Admin obj1 = new Admin();
            obj1.Show();
            this.Hide();
        }
    }
}
