
namespace BomberMan {
    partial class RegisterForm {
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
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Play = new System.Windows.Forms.Label();
            this.timer_animation = new System.Windows.Forms.Timer(this.components);
            this.lineSlide = new System.Windows.Forms.Label();
            this.pictureBox_Character = new System.Windows.Forms.PictureBox();
            this.Name_RealTime = new System.Windows.Forms.Label();
            this.line_type = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayerName.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerName.Location = new System.Drawing.Point(409, 153);
            this.txtPlayerName.MaxLength = 8;
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(277, 29);
            this.txtPlayerName.TabIndex = 0;
            this.txtPlayerName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtPlayerName_MouseClick);
            this.txtPlayerName.TextChanged += new System.EventHandler(this.txtPlayerName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(405, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "PLAYER NAME";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(409, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(277, 2);
            this.label2.TabIndex = 2;
            // 
            // btn_Play
            // 
            this.btn_Play.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Play.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Play.Location = new System.Drawing.Point(575, 199);
            this.btn_Play.Name = "btn_Play";
            this.btn_Play.Size = new System.Drawing.Size(108, 41);
            this.btn_Play.TabIndex = 3;
            this.btn_Play.Text = "PLAY";
            this.btn_Play.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_Play.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Play_MouseClick);
            this.btn_Play.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_Play_MouseDown);
            this.btn_Play.MouseLeave += new System.EventHandler(this.btn_Play_MouseLeave);
            this.btn_Play.MouseHover += new System.EventHandler(this.btn_Play_MouseHover);
            // 
            // timer_animation
            // 
            this.timer_animation.Enabled = true;
            this.timer_animation.Interval = 15;
            this.timer_animation.Tick += new System.EventHandler(this.timer_animation_Tick);
            // 
            // lineSlide
            // 
            this.lineSlide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lineSlide.Location = new System.Drawing.Point(409, 182);
            this.lineSlide.Name = "lineSlide";
            this.lineSlide.Size = new System.Drawing.Size(0, 2);
            this.lineSlide.TabIndex = 4;
            // 
            // pictureBox_Character
            // 
            this.pictureBox_Character.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_Character.Location = new System.Drawing.Point(178, 241);
            this.pictureBox_Character.Name = "pictureBox_Character";
            this.pictureBox_Character.Size = new System.Drawing.Size(77, 80);
            this.pictureBox_Character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Character.TabIndex = 5;
            this.pictureBox_Character.TabStop = false;
            // 
            // Name_RealTime
            // 
            this.Name_RealTime.AutoSize = true;
            this.Name_RealTime.BackColor = System.Drawing.Color.Transparent;
            this.Name_RealTime.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_RealTime.Location = new System.Drawing.Point(180, 205);
            this.Name_RealTime.Name = "Name_RealTime";
            this.Name_RealTime.Size = new System.Drawing.Size(0, 28);
            this.Name_RealTime.TabIndex = 6;
            // 
            // line_type
            // 
            this.line_type.BackColor = System.Drawing.Color.Blue;
            this.line_type.Location = new System.Drawing.Point(409, 182);
            this.line_type.Name = "line_type";
            this.line_type.Size = new System.Drawing.Size(0, 2);
            this.line_type.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(94, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 191);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblWarning.Location = new System.Drawing.Point(538, 163);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(145, 13);
            this.lblWarning.TabIndex = 1;
            this.lblWarning.Text = "Please type 8 charaters";
            this.lblWarning.Visible = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Name_RealTime);
            this.Controls.Add(this.pictureBox_Character);
            this.Controls.Add(this.line_type);
            this.Controls.Add(this.btn_Play);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lineSlide);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label btn_Play;
        private System.Windows.Forms.Timer timer_animation;
        private System.Windows.Forms.Label lineSlide;
        private System.Windows.Forms.PictureBox pictureBox_Character;
        private System.Windows.Forms.Label Name_RealTime;
        private System.Windows.Forms.Label line_type;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblWarning;
    }
}