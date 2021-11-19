
namespace BomberMan {
    partial class StateForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.btnRestart = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Label();
            this.pictureBox_StateGame = new System.Windows.Forms.PictureBox();
            this.lblState = new System.Windows.Forms.Label();
            this.timer_Animation = new System.Windows.Forms.Timer(this.components);
            this.LineSlide1 = new System.Windows.Forms.Label();
            this.LineSlide2 = new System.Windows.Forms.Label();
            this.lblHighScoreBox = new System.Windows.Forms.Label();
            this.lblScoreBox = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblBestPlayerName = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.pictureBox_BestPlayerFace = new System.Windows.Forms.PictureBox();
            this.pictureBox_PlayerFace = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_StateGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BestPlayerFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerFace)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Font = new System.Drawing.Font("Consolas", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.ForeColor = System.Drawing.Color.Black;
            this.btnRestart.Location = new System.Drawing.Point(250, 320);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(265, 73);
            this.btnRestart.TabIndex = 4;
            this.btnRestart.Text = "RESTART";
            this.btnRestart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            this.btnRestart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnRestart_MouseClick);
            this.btnRestart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnRestart_MouseDown);
            this.btnRestart.MouseLeave += new System.EventHandler(this.btnRestart_MouseLeave);
            this.btnRestart.MouseHover += new System.EventHandler(this.btnRestart_MouseHover);
            // 
            // btnMenu
            // 
            this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Font = new System.Drawing.Font("Consolas", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.ForeColor = System.Drawing.Color.Black;
            this.btnMenu.Location = new System.Drawing.Point(523, 320);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(228, 73);
            this.btnMenu.TabIndex = 5;
            this.btnMenu.Text = "MENU";
            this.btnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            this.btnMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnMenu_MouseDown);
            this.btnMenu.MouseLeave += new System.EventHandler(this.btnMenu_MouseLeave);
            this.btnMenu.MouseHover += new System.EventHandler(this.btnMenu_MouseHover);
            // 
            // pictureBox_StateGame
            // 
            this.pictureBox_StateGame.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox_StateGame.Location = new System.Drawing.Point(51, 98);
            this.pictureBox_StateGame.Name = "pictureBox_StateGame";
            this.pictureBox_StateGame.Size = new System.Drawing.Size(192, 295);
            this.pictureBox_StateGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_StateGame.TabIndex = 6;
            this.pictureBox_StateGame.TabStop = false;
            // 
            // lblState
            // 
            this.lblState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblState.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblState.Location = new System.Drawing.Point(51, 16);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(699, 72);
            this.lblState.TabIndex = 7;
            this.lblState.Text = "GAME WIN";
            this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_Animation
            // 
            this.timer_Animation.Enabled = true;
            this.timer_Animation.Interval = 10;
            this.timer_Animation.Tick += new System.EventHandler(this.timer_Animation_Tick);
            // 
            // LineSlide1
            // 
            this.LineSlide1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LineSlide1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LineSlide1.Font = new System.Drawing.Font("Consolas", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineSlide1.Location = new System.Drawing.Point(250, 391);
            this.LineSlide1.Name = "LineSlide1";
            this.LineSlide1.Size = new System.Drawing.Size(0, 2);
            this.LineSlide1.TabIndex = 8;
            this.LineSlide1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LineSlide2
            // 
            this.LineSlide2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LineSlide2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LineSlide2.Font = new System.Drawing.Font("Consolas", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LineSlide2.Location = new System.Drawing.Point(523, 391);
            this.LineSlide2.Name = "LineSlide2";
            this.LineSlide2.Size = new System.Drawing.Size(0, 2);
            this.LineSlide2.TabIndex = 9;
            this.LineSlide2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHighScoreBox
            // 
            this.lblHighScoreBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHighScoreBox.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScoreBox.ForeColor = System.Drawing.Color.Navy;
            this.lblHighScoreBox.Location = new System.Drawing.Point(523, 98);
            this.lblHighScoreBox.Name = "lblHighScoreBox";
            this.lblHighScoreBox.Size = new System.Drawing.Size(227, 82);
            this.lblHighScoreBox.TabIndex = 7;
            this.lblHighScoreBox.Text = "BEST SCORE \r\n";
            this.lblHighScoreBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblHighScoreBox.UseCompatibleTextRendering = true;
            // 
            // lblScoreBox
            // 
            this.lblScoreBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblScoreBox.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreBox.ForeColor = System.Drawing.Color.Purple;
            this.lblScoreBox.Location = new System.Drawing.Point(523, 196);
            this.lblScoreBox.Name = "lblScoreBox";
            this.lblScoreBox.Size = new System.Drawing.Size(227, 82);
            this.lblScoreBox.TabIndex = 7;
            this.lblScoreBox.Text = "YOUR SCORE ";
            this.lblScoreBox.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblScoreBox.UseCompatibleTextRendering = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 298);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 1);
            this.label1.TabIndex = 10;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // lblHighScore
            // 
            this.lblHighScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblHighScore.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblHighScore.Location = new System.Drawing.Point(523, 124);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(227, 47);
            this.lblHighScore.TabIndex = 7;
            this.lblHighScore.Text = "123456";
            this.lblHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighScore.UseCompatibleTextRendering = true;
            // 
            // lblScore
            // 
            this.lblScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblScore.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblScore.Location = new System.Drawing.Point(523, 221);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(227, 47);
            this.lblScore.TabIndex = 13;
            this.lblScore.Text = "123456";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScore.UseCompatibleTextRendering = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Navy;
            this.label4.Location = new System.Drawing.Point(326, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 82);
            this.label4.TabIndex = 7;
            this.label4.Text = "BEST PLAYER";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.UseCompatibleTextRendering = true;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(326, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 82);
            this.label5.TabIndex = 7;
            this.label5.Text = "PLAYER";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.UseCompatibleTextRendering = true;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(249, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 82);
            this.label6.TabIndex = 14;
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.UseCompatibleTextRendering = true;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(249, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 82);
            this.label7.TabIndex = 15;
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.UseCompatibleTextRendering = true;
            // 
            // lblBestPlayerName
            // 
            this.lblBestPlayerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblBestPlayerName.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBestPlayerName.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblBestPlayerName.Location = new System.Drawing.Point(326, 124);
            this.lblBestPlayerName.Name = "lblBestPlayerName";
            this.lblBestPlayerName.Size = new System.Drawing.Size(191, 47);
            this.lblBestPlayerName.TabIndex = 7;
            this.lblBestPlayerName.Text = "LnwPREM1";
            this.lblBestPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBestPlayerName.UseCompatibleTextRendering = true;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.lblPlayerName.Font = new System.Drawing.Font("Consolas", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.ForeColor = System.Drawing.Color.MediumVioletRed;
            this.lblPlayerName.Location = new System.Drawing.Point(326, 221);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(191, 47);
            this.lblPlayerName.TabIndex = 13;
            this.lblPlayerName.Text = "LnwJENG1";
            this.lblPlayerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPlayerName.UseCompatibleTextRendering = true;
            // 
            // pictureBox_BestPlayerFace
            // 
            this.pictureBox_BestPlayerFace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox_BestPlayerFace.Location = new System.Drawing.Point(254, 107);
            this.pictureBox_BestPlayerFace.Name = "pictureBox_BestPlayerFace";
            this.pictureBox_BestPlayerFace.Size = new System.Drawing.Size(71, 65);
            this.pictureBox_BestPlayerFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_BestPlayerFace.TabIndex = 16;
            this.pictureBox_BestPlayerFace.TabStop = false;
            // 
            // pictureBox_PlayerFace
            // 
            this.pictureBox_PlayerFace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox_PlayerFace.Location = new System.Drawing.Point(255, 205);
            this.pictureBox_PlayerFace.Name = "pictureBox_PlayerFace";
            this.pictureBox_PlayerFace.Size = new System.Drawing.Size(71, 65);
            this.pictureBox_PlayerFace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_PlayerFace.TabIndex = 17;
            this.pictureBox_PlayerFace.TabStop = false;
            // 
            // StateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(806, 413);
            this.Controls.Add(this.pictureBox_PlayerFace);
            this.Controls.Add(this.pictureBox_BestPlayerFace);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LineSlide2);
            this.Controls.Add(this.LineSlide1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblScoreBox);
            this.Controls.Add(this.lblBestPlayerName);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblHighScoreBox);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.pictureBox_StateGame);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnRestart);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THE STUDENT BOMBER";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StateForm_FormClosed);
            this.Load += new System.EventHandler(this.StateForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_StateGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BestPlayerFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_PlayerFace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label btnRestart;
        private System.Windows.Forms.Label btnMenu;
        private System.Windows.Forms.PictureBox pictureBox_StateGame;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Timer timer_Animation;
        private System.Windows.Forms.Label LineSlide1;
        private System.Windows.Forms.Label LineSlide2;
        private System.Windows.Forms.Label lblHighScoreBox;
        private System.Windows.Forms.Label lblScoreBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblBestPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.PictureBox pictureBox_BestPlayerFace;
        private System.Windows.Forms.PictureBox pictureBox_PlayerFace;
    }
}
