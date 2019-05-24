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
    public partial class frmResult : Form
    {
        public frmResult()
        {
            InitializeComponent();
        }

        private void BntRestart_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmWelcome novo = new frmWelcome();
            novo.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Are you sure that you would like to close the form ? ", "System message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void TxtTotDraw_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtTotGames_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtPercWins_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtPercLoses_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtTotWins_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
