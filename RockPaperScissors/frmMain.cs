using RockPaperScissors;
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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        int scoreHuman, scoreComputer, scoreDraw = 0;

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            //PAPER
            playerRound(1);
        }
        private void PicRock_Click(object sender, EventArgs e)
        {
            //ROCK
            playerRound(2);
        }

        private void PciScissors_Click(object sender, EventArgs e)
        {
            //SCISSORS
            playerRound(3);
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //RESTART GAME
            // reset all the values and goes to the Welcome page (frmWelcome)
            scoreDraw = 0;
            scoreHuman = '0';
            //txtScoreDraw.Text = "0";
            txtScoreComputer.Text = "0";
            lblDraw.Visible = false;
            lblLose.Visible = false;
            lblWin.Visible = false;

            //Close this form and open frmWelcome
            this.Hide();
            frmWelcome novo = new frmWelcome();
            novo.Show();

        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        { }

        private void PicComputer_Click(object sender, EventArgs e)
        {

        }

        private void PicSourceScissors_Click(object sender, EventArgs e)
        {

        }

        private void playerRound(int selection)
        {
            Random rnd = new Random();
            int enemySelection = rnd.Next(1, 4);

            setImage(picPlayer, selection);
            setImage(picComputer, enemySelection);

            if (enemySelection == selection)
            {
                scoreDraw++;
                
                lblDraw.Visible = true;
                lblLose.Visible = false;
                lblWin.Visible = false;

                return;
            }

            switch (selection)
            {
                case 1:
                    if (enemySelection == 2)
                        UpdateScore(true);
                    else
                        UpdateScore(false);
                    break;

                case 2:
                    if (enemySelection == 3)
                        UpdateScore(true);
                    else
                        UpdateScore(false);
                    break;

                case 3:
                    if (enemySelection == 1)
                        UpdateScore(true);
                    else
                        UpdateScore(false);
                    break;
            }
        }

        private void UpdateScore(bool playerWon)
        {
            if (playerWon)
            {
                scoreHuman++;
                txtScoreHuman.Text = scoreHuman.ToString();

                lblDraw.Visible = false;
                lblLose.Visible = false;
                lblWin.Visible = true;
            }

            else
            {
                scoreComputer++;
                txtScoreComputer.Text = scoreComputer.ToString();

                lblDraw.Visible = false;
                lblLose.Visible = true;
                lblWin.Visible = false;
            }
        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void PicSourcePaper_Click(object sender, EventArgs e)
        {
                    }

        private void Label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmResult novo = new frmResult();

            novo.txtTotGames.Text = (scoreComputer + scoreHuman + scoreDraw).ToString();
            novo.txtTotDraw.Text = scoreDraw.ToString();
            novo.txtTotLoses.Text = (scoreComputer).ToString();
            novo.txtTotWins.Text = scoreHuman.ToString();


            var oldNewTotWins = novo.txtTotWins.Text;
            int newTotWins = int.Parse(oldNewTotWins);

            var oldNewTotDraws = novo.txtTotDraw.Text;
            int newTotDraws = int.Parse(oldNewTotDraws);

            var oldNewTotGames = novo.txtTotGames.Text;
            int newTotGames = int.Parse(oldNewTotGames);

            var oldNewTotLoses = novo.txtTotLoses.Text;
            decimal newTotLoses = decimal.Parse(oldNewTotGames);

            novo.txtPercWins.Text = (newTotWins/newTotGames).ToString();

            novo.txtPercDraws.Text = (newTotDraws/newTotGames).ToString();

            novo.txtPercLoses.Text = (newTotLoses/newTotGames).ToString();

            novo.Show();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PnlHideDraw_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Are you sure that you would like to close the form ? ", "System message ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void setImage(PictureBox pb, int img)
        {
            if (img == 1)
                pb.Image = global::RockPaperScissors.Properties.Resources.m_paper;
            else if (img == 2)
                pb.Image = global::RockPaperScissors.Properties.Resources.m_rock;
            else if (img == 3)
                pb.Image = global::RockPaperScissors.Properties.Resources.m_scissors;
        }
    }
}
