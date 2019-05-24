namespace RockPaperScissors
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblHuman = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.txtScoreHuman = new System.Windows.Forms.Label();
            this.txtScoreComputer = new System.Windows.Forms.Label();
            this.bntRestart = new System.Windows.Forms.Button();
            this.txtShowResult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.picComputer = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picRock = new System.Windows.Forms.PictureBox();
            this.picScissors = new System.Windows.Forms.PictureBox();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDraw = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblLose = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHuman
            // 
            this.lblHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuman.Location = new System.Drawing.Point(32, 85);
            this.lblHuman.Name = "lblHuman";
            this.lblHuman.Size = new System.Drawing.Size(283, 31);
            this.lblHuman.TabIndex = 5;
            this.lblHuman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHuman.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.Location = new System.Drawing.Point(537, 85);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(133, 31);
            this.lblComputer.TabIndex = 6;
            this.lblComputer.Text = "Computer";
            // 
            // txtScoreHuman
            // 
            this.txtScoreHuman.BackColor = System.Drawing.SystemColors.Menu;
            this.txtScoreHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScoreHuman.Location = new System.Drawing.Point(32, 130);
            this.txtScoreHuman.Name = "txtScoreHuman";
            this.txtScoreHuman.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtScoreHuman.Size = new System.Drawing.Size(283, 31);
            this.txtScoreHuman.TabIndex = 7;
            this.txtScoreHuman.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtScoreComputer
            // 
            this.txtScoreComputer.AutoSize = true;
            this.txtScoreComputer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScoreComputer.Location = new System.Drawing.Point(602, 128);
            this.txtScoreComputer.Name = "txtScoreComputer";
            this.txtScoreComputer.Size = new System.Drawing.Size(0, 31);
            this.txtScoreComputer.TabIndex = 8;
            // 
            // bntRestart
            // 
            this.bntRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntRestart.Location = new System.Drawing.Point(7, 34);
            this.bntRestart.Name = "bntRestart";
            this.bntRestart.Size = new System.Drawing.Size(88, 69);
            this.bntRestart.TabIndex = 11;
            this.bntRestart.Text = "&Restart Game";
            this.bntRestart.UseVisualStyleBackColor = true;
            this.bntRestart.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtShowResult
            // 
            this.txtShowResult.AutoSize = true;
            this.txtShowResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowResult.Location = new System.Drawing.Point(369, 292);
            this.txtShowResult.Name = "txtShowResult";
            this.txtShowResult.Size = new System.Drawing.Size(0, 31);
            this.txtShowResult.TabIndex = 15;
            this.txtShowResult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtShowResult.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button1.Location = new System.Drawing.Point(100, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 69);
            this.button1.TabIndex = 16;
            this.button1.Text = "&Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(179, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 31);
            this.label1.TabIndex = 18;
            this.label1.Text = "Rock, Paper, Scissors, the GAME";
            this.label1.Click += new System.EventHandler(this.Label1_Click_2);
            // 
            // picComputer
            // 
            this.picComputer.Location = new System.Drawing.Point(463, 168);
            this.picComputer.Name = "picComputer";
            this.picComputer.Size = new System.Drawing.Size(283, 330);
            this.picComputer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picComputer.TabIndex = 4;
            this.picComputer.TabStop = false;
            this.picComputer.Click += new System.EventHandler(this.PicComputer_Click);
            // 
            // picPlayer
            // 
            this.picPlayer.Location = new System.Drawing.Point(32, 168);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(283, 330);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 3;
            this.picPlayer.TabStop = false;
            this.picPlayer.Click += new System.EventHandler(this.PictureBox4_Click);
            // 
            // picRock
            // 
            this.picRock.Image = global::RockPaperScissors.Properties.Resources.p_rock;
            this.picRock.Location = new System.Drawing.Point(150, 556);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(56, 69);
            this.picRock.TabIndex = 2;
            this.picRock.TabStop = false;
            this.picRock.Click += new System.EventHandler(this.PicRock_Click);
            // 
            // picScissors
            // 
            this.picScissors.Image = ((System.Drawing.Image)(resources.GetObject("picScissors.Image")));
            this.picScissors.Location = new System.Drawing.Point(239, 556);
            this.picScissors.Name = "picScissors";
            this.picScissors.Size = new System.Drawing.Size(56, 69);
            this.picScissors.TabIndex = 1;
            this.picScissors.TabStop = false;
            this.picScissors.Click += new System.EventHandler(this.PciScissors_Click);
            // 
            // picPaper
            // 
            this.picPaper.Image = ((System.Drawing.Image)(resources.GetObject("picPaper.Image")));
            this.picPaper.Location = new System.Drawing.Point(59, 556);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(56, 69);
            this.picPaper.TabIndex = 0;
            this.picPaper.TabStop = false;
            this.picPaper.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(192, 34);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 69);
            this.button3.TabIndex = 19;
            this.button3.Text = "Res&ults";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox1.Location = new System.Drawing.Point(32, 522);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 121);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose your option";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bntRestart);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.groupBox2.Location = new System.Drawing.Point(463, 522);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 121);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Menu";
            // 
            // lblDraw
            // 
            this.lblDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDraw.Location = new System.Drawing.Point(321, 317);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(136, 31);
            this.lblDraw.TabIndex = 24;
            this.lblDraw.Text = "Draw";
            this.lblDraw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDraw.Click += new System.EventHandler(this.Label2_Click_1);
            // 
            // lblWin
            // 
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblWin.Location = new System.Drawing.Point(321, 323);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(136, 31);
            this.lblWin.TabIndex = 25;
            this.lblWin.Text = "You WIN";
            this.lblWin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLose
            // 
            this.lblLose.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLose.ForeColor = System.Drawing.Color.Red;
            this.lblLose.Location = new System.Drawing.Point(317, 317);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(147, 31);
            this.lblLose.TabIndex = 26;
            this.lblLose.Text = "You LOSE";
            this.lblLose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 655);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtShowResult);
            this.Controls.Add(this.txtScoreComputer);
            this.Controls.Add(this.txtScoreHuman);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblHuman);
            this.Controls.Add(this.picComputer);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picRock);
            this.Controls.Add(this.picScissors);
            this.Controls.Add(this.picPaper);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblLose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock, Paper, Scissors, The GAME";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.PictureBox picScissors;
        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picComputer;
        public System.Windows.Forms.Label lblHuman;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.Label txtScoreHuman;
        private System.Windows.Forms.Label txtScoreComputer;
        private System.Windows.Forms.Button bntRestart;
        private System.Windows.Forms.Label txtShowResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDraw;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblLose;
    }
}

