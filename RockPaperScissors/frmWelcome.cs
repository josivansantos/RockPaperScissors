using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void BntRestart_Click(object sender, EventArgs e)
        {

            if (txtGetName.Text == string.Empty)
                {
                    MessageBox.Show("Please, type your name!", "System message", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

            else

            this.Hide();
            frmMain novo = new frmMain();
            novo.lblHuman.Text = txtGetName.Text;
            novo.Show();                                   

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Are you sure that you would like to close the form ? ", "System message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void LblHuman_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();          
            frmCredits novo = new frmCredits();
            novo.Show();
        }
    }
}
