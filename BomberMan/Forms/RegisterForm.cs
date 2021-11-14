using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BomberMan {
    public partial class RegisterForm : Form {
        private int lineSpeed = 10;
        private bool focus;

        public RegisterForm() {
            InitializeComponent();

            lineSlide.Width = 0;

            this.BackColor = Colors.White;
            this.Icon = new Icon(Images.IconGame);

            btn_Play.BackColor = Colors.OrangeLeave;
            lineSlide.BackColor = Colors.OrangeLine;
            Name_RealTime.ForeColor = Color.White;

            pictureBox_Character.Image = PlayerImage.Idle;
            pictureBox1.Image = Images.Blackboard;

            // Tranparent picture
            // Player
            pictureBox1.Controls.Add(pictureBox_Character);
            pictureBox_Character.Location = new Point(95, 70);
            pictureBox_Character.BringToFront();

            // Label name
            pictureBox1.Controls.Add(Name_RealTime);
            Name_RealTime.Location = new Point(75, 40);
            Name_RealTime.BringToFront();
        }

        // ----------------
        // ANIMATION BUTTON
        // ----------------
        private void timer_animation_Tick(object sender, EventArgs e) {
            if (lineSlide.Width <= txtPlayerName.Width && focus) {
                lineSlide.Width += lineSpeed;
            }
            btn_Play.Enabled = (txtPlayerName.Text.Length < 8) ? false : true;
        }

        private void txtPlayerName_MouseClick(object sender, MouseEventArgs e) {
            focus = true;
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e) {
            Name_RealTime.Text = txtPlayerName.Text;
            line_type.Width = 13 * txtPlayerName.Text.Length;
            pictureBox_Character.Image = (txtPlayerName.Text.Length == 8) ? PlayerImage.RunDown : PlayerImage.Idle;
            
            lblWarning.Visible = (txtPlayerName.Text.Length < 8 && txtPlayerName.Text.Length > 0) ? true : false;
            if (!(lblWarning.Visible) && txtPlayerName.Text.Length == 8) {
                lblWarning.Visible = true; 
                lblWarning.Text = "This name can be used";
                lblWarning.ForeColor = Colors.Success;
            }
            else {
                lblWarning.Text = "Please type 8 charaters";
                lblWarning.ForeColor = Colors.Warning;
            }
        }

        private void btn_Play_MouseHover(object sender, EventArgs e) {
            btn_Play.BackColor = Colors.OrangeHover;
        }

        private void btn_Play_MouseLeave(object sender, EventArgs e) {
            btn_Play.BackColor = Colors.OrangeLeave;
        }

        private void btn_Play_MouseClick(object sender, MouseEventArgs e) {
            btn_Play.BackColor = Colors.OrangeClick;

            //BackGroundMusic.Stop();
            /// ** Music.MainTheme use for test
            /// actually we will use Music.GameTheme
            //BackGroundMusic.Set(Music.GameTheme);
            // BackGroundMusic.Set(Music.MainTheme);
            //BackGroundMusic.Play();

            Game GameForm = new Game($"{Name_RealTime.Text}");
            this.Close();
            GameForm.Show();
        }

        private void btn_Play_MouseDown(object sender, MouseEventArgs e) {
            btn_Play.BackColor = Colors.OrangeClick;
        }
    }
}
