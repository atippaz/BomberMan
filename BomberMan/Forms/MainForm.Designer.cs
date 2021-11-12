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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Label();
            this.lineSlide1 = new System.Windows.Forms.Label();
            this.timer_Animation = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_EXIT = new System.Windows.Forms.Label();
            this.lineSlide2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(648, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "OpenForm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OpenGameForm);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(648, 181);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.CloseForm);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(636, 28);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 69);
            this.button3.TabIndex = 2;
            this.button3.Text = "test Effect";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Play_Effect);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Start.Font = new System.Drawing.Font("Consolas", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.Color.Black;
            this.btn_Start.Location = new System.Drawing.Point(286, 244);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(237, 73);
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
            this.lineSlide1.Location = new System.Drawing.Point(52, 244);
            this.lineSlide1.Name = "lineSlide1";
            this.lineSlide1.Size = new System.Drawing.Size(237, 76);
            this.lineSlide1.TabIndex = 4;
            this.lineSlide1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_Animation
            // 
            this.timer_Animation.Enabled = true;
            this.timer_Animation.Interval = 10;
            this.timer_Animation.Tick += new System.EventHandler(this.timer_Animation_Tick);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Consolas", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 177);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_EXIT
            // 
            this.btn_EXIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_EXIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EXIT.Font = new System.Drawing.Font("Consolas", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EXIT.ForeColor = System.Drawing.Color.Black;
            this.btn_EXIT.Location = new System.Drawing.Point(286, 345);
            this.btn_EXIT.Name = "btn_EXIT";
            this.btn_EXIT.Size = new System.Drawing.Size(237, 73);
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
            this.lineSlide2.Location = new System.Drawing.Point(52, 345);
            this.lineSlide2.Name = "lineSlide2";
            this.lineSlide2.Size = new System.Drawing.Size(237, 76);
            this.lineSlide2.TabIndex = 8;
            this.lineSlide2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_EXIT);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lineSlide1);
            this.Controls.Add(this.lineSlide2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Setup);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label btn_Start;
        private System.Windows.Forms.Label lineSlide1;
        private System.Windows.Forms.Timer timer_Animation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label btn_EXIT;
        private System.Windows.Forms.Label lineSlide2;
    }
}

