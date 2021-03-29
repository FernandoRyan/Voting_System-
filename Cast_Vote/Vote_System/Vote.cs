using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vote_System
{
    public partial class Vote : Form
    {
        public Vote()
        {
            InitializeComponent();
        }

        private void Vote_Btn_Click(object sender, EventArgs e)
        {
            Cast_Vote cv = new Cast_Vote();
            cv.Show();
            this.Hide();
        }

        private void Vote_Btn_MouseEnter(object sender, EventArgs e)
        {
            Vote_Btn.BackColor = Color.FromArgb(3, 80, 111);
        }

        private void Vote_Btn_MouseLeave(object sender, EventArgs e)
        {
            Vote_Btn.BackColor = Color.FromArgb(163, 221, 203);
        }
    }
}
