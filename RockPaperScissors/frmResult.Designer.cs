namespace RockPaperScissors
{
    partial class frmResult
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
            this.button1 = new System.Windows.Forms.Button();
            this.bntRestart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblHuman = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotGames = new System.Windows.Forms.TextBox();
            this.txtTotWins = new System.Windows.Forms.TextBox();
            this.txtTotLoses = new System.Windows.Forms.TextBox();
            this.txtTotDraw = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(429, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 69);
            this.button1.TabIndex = 20;
            this.button1.Text = "&Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // bntRestart
            // 
            this.bntRestart.Location = new System.Drawing.Point(203, 334);
            this.bntRestart.Name = "bntRestart";
            this.bntRestart.Size = new System.Drawing.Size(169, 69);
            this.bntRestart.TabIndex = 19;
            this.bntRestart.Text = "&Back to the Game";
            this.bntRestart.UseVisualStyleBackColor = true;
            this.bntRestart.Click += new System.EventHandler(this.BntRestart_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Location = new System.Drawing.Point(42, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 10);
            this.panel1.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(281, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 31);
            this.label5.TabIndex = 30;
            this.label5.Text = "Draws:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(286, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 31);
            this.label4.TabIndex = 29;
            this.label4.Text = "Loses:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(299, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 31);
            this.label3.TabIndex = 28;
            this.label3.Text = "Wins:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(210, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 31);
            this.label2.TabIndex = 27;
            this.label2.Text = "Total games:";
            // 
            // lblHuman
            // 
            this.lblHuman.AutoSize = true;
            this.lblHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHuman.Location = new System.Drawing.Point(345, 72);
            this.lblHuman.Name = "lblHuman";
            this.lblHuman.Size = new System.Drawing.Size(106, 31);
            this.lblHuman.TabIndex = 26;
            this.lblHuman.Text = "Results";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(180, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 31);
            this.label1.TabIndex = 32;
            this.label1.Text = "Rock, Paper, Scissors, the GAME";
            // 
            // txtTotGames
            // 
            this.txtTotGames.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotGames.Location = new System.Drawing.Point(387, 137);
            this.txtTotGames.Name = "txtTotGames";
            this.txtTotGames.Size = new System.Drawing.Size(211, 38);
            this.txtTotGames.TabIndex = 33;
            this.txtTotGames.TextChanged += new System.EventHandler(this.TxtTotGames_TextChanged);
            // 
            // txtTotWins
            // 
            this.txtTotWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotWins.Location = new System.Drawing.Point(387, 185);
            this.txtTotWins.Name = "txtTotWins";
            this.txtTotWins.Size = new System.Drawing.Size(211, 38);
            this.txtTotWins.TabIndex = 34;
            this.txtTotWins.TextChanged += new System.EventHandler(this.TxtTotWins_TextChanged);
            // 
            // txtTotLoses
            // 
            this.txtTotLoses.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotLoses.Location = new System.Drawing.Point(387, 233);
            this.txtTotLoses.Name = "txtTotLoses";
            this.txtTotLoses.Size = new System.Drawing.Size(211, 38);
            this.txtTotLoses.TabIndex = 35;
            // 
            // txtTotDraw
            // 
            this.txtTotDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotDraw.Location = new System.Drawing.Point(387, 279);
            this.txtTotDraw.Name = "txtTotDraw";
            this.txtTotDraw.Size = new System.Drawing.Size(211, 38);
            this.txtTotDraw.TabIndex = 36;
            this.txtTotDraw.TextChanged += new System.EventHandler(this.TxtTotDraw_TextChanged);
            // 
            // frmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTotDraw);
            this.Controls.Add(this.txtTotLoses);
            this.Controls.Add(this.txtTotWins);
            this.Controls.Add(this.txtTotGames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblHuman);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bntRestart);
            this.Name = "frmResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntRestart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHuman;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtTotGames;
        public System.Windows.Forms.TextBox txtTotWins;
        public System.Windows.Forms.TextBox txtTotLoses;
        public System.Windows.Forms.TextBox txtTotDraw;
    }
}