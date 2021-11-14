namespace BomberMan
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btn_Start = new System.Windows.Forms.Label();
            this.lineSlide1 = new System.Windows.Forms.Label();
            this.timer_Animation = new System.Windows.Forms.Timer(this.components);
            this.btn_EXIT = new System.Windows.Forms.Label();
            this.lineSlide2 = new System.Windows.Forms.Label();
            this.pictureBox_Logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Start.Font = new System.Drawing.Font("Consolas", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.Color.Black;
            this.btn_Start.Location = new System.Drawing.Point(280, 232);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(250, 73);
            this.btn_Start.TabIndex = 3;
            this.btn_Start.Text = "START";
            this.btn_Start.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Start.Click += new System.EventHandler(this.OpenGameForm);
            this.btn_Start.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Start_MouseClick);
            this.btn_Start.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Start_MouseDown);
            this.btn_Start.MouseLeave += new System.EventHandler(this.btn_Start_MouseLeave);
            this.btn_Start.MouseHover += new System.EventHandler(this.btn_Start_MouseHover);
            // 
            // lineSlide1
            // 
            this.lineSlide1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lineSlide1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lineSlide1.Font = new System.Drawing.Font("Consolas", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineSlide1.Location = new System.Drawing.Point(280, 304);
            this.lineSlide1.Name = "lineSlide1";
            this.lineSlide1.Size = new System.Drawing.Size(0, 2);
            this.lineSlide1.TabIndex = 4;
            this.lineSlide1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_Animation
            // 
            this.timer_Animation.Enabled = true;
            this.timer_Animation.Interval = 10;
            this.timer_Animation.Tick += new System.EventHandler(this.timer_Animation_Tick);
            // 
            // btn_EXIT
            // 
            this.btn_EXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_EXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EXIT.Font = new System.Drawing.Font("Consolas", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EXIT.ForeColor = System.Drawing.Color.Black;
            this.btn_EXIT.Location = new System.Drawing.Point(280, 332);
            this.btn_EXIT.Name = "btn_EXIT";
            this.btn_EXIT.Size = new System.Drawing.Size(250, 73);
            this.btn_EXIT.TabIndex = 7;
            this.btn_EXIT.Text = "EXIT";
            this.btn_EXIT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_EXIT.Click += new System.EventHandler(this.CloseForm);
            this.btn_EXIT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_EXIT_MouseClick);
            this.btn_EXIT.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_EXIT_MouseDown);
            this.btn_EXIT.MouseLeave += new System.EventHandler(this.btn_EXIT_MouseLeave);
            this.btn_EXIT.MouseHover += new System.EventHandler(this.btn_EXIT_MouseHover);
            // 
            // lineSlide2
            // 
            this.lineSlide2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lineSlide2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lineSlide2.Font = new System.Drawing.Font("Consolas", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineSlide2.Location = new System.Drawing.Point(280, 405);
            this.lineSlide2.Name = "lineSlide2";
            this.lineSlide2.Size = new System.Drawing.Size(0, 2);
            this.lineSlide2.TabIndex = 8;
            this.lineSlide2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox_Logo
            // 
            this.pictureBox_Logo.Location = new System.Drawing.Point(135, 43);
            this.pictureBox_Logo.Name = "pictureBox_Logo";
            this.pictureBox_Logo.Size = new System.Drawing.Size(500, 157);
            this.pictureBox_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox_Logo.TabIndex = 9;
            this.pictureBox_Logo.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lineSlide2);
            this.Controls.Add(this.lineSlide1);
            this.Controls.Add(this.pictureBox_Logo);
            this.Controls.Add(this.btn_EXIT);
            this.Controls.Add(this.btn_Start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THE STUDENT BOMBER";
            this.Load += new System.EventHandler(this.Setup);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label btn_Start;
        private System.Windows.Forms.Label lineSlide1;
        private System.Windows.Forms.Timer timer_Animation;
        private System.Windows.Forms.Label btn_EXIT;
        private System.Windows.Forms.Label lineSlide2;
        private System.Windows.Forms.PictureBox pictureBox_Logo;
    }
}

