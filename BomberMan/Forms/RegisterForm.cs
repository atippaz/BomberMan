using System;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan {
    public partial class RegisterForm : Form {
        #region Fields
        private int lineSpeed = 10;
        private bool focus;
        #endregion
        public RegisterForm() {
            InitializeComponent();
            #region initial value to Controls
            this.BackColor = Colors.White;
            this.Icon = new Icon(Images.IconGame);

            btn_Play.BackColor = Colors.OrangeLeave;
            lineSlide.BackColor = Colors.OrangeLine;
            Name_RealTime.ForeColor = Color.White;

            pictureBox_Character.Image = PlayerImage.Idle;
            pictureBox1.Image = Images.Blackboard;
            #endregion
            #region Tranparent pictures
            // Player
            pictureBox1.Controls.Add(pictureBox_Character);
            pictureBox_Character.Location = new Point(95, 70);
            pictureBox_Character.BringToFront();

            // Label name
            pictureBox1.Controls.Add(Name_RealTime);
            Name_RealTime.Location = new Point(75, 40);
            Name_RealTime.BringToFront();
            #endregion
        }

        #region ANIMATION BUTTON

        private void timer_animation_Tick(object sender, EventArgs e) {
            if (lineSlide.Width <= txtPlayerName.Width && focus) {
                lineSlide.Width += lineSpeed;
            }
            btn_Play.Enabled = (txtPlayerName.Text.Length < 8) ? false : true;
        }
        #endregion

        #region PLAY BUTTON
        private void btn_Play_Click(object sender, EventArgs e) {
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
        private void btn_Play_MouseHover(object sender, EventArgs e) {
            btn_Play.BackColor = Colors.OrangeHover;
        }
        private void btn_Play_MouseLeave(object sender, EventArgs e) {
            btn_Play.BackColor = Colors.OrangeLeave;
        }
        private void btn_Play_MouseClick(object sender, MouseEventArgs e) {
            btn_Play.BackColor = Colors.OrangeClick;
        }
        private void btn_Play_MouseDown(object sender, MouseEventArgs e) {
            btn_Play.BackColor = Colors.OrangeClick;
        }
        #endregion

        #region PLAYER NAME TEXTBOX
        private void txtPlayerName_MouseClick(object sender, MouseEventArgs e) {
            focus = true;
        }
        private void txtPlayerName_KeyPress(object sender, KeyPressEventArgs e) {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space);
        }
        private void txtPlayerName_TextChanged(object sender, EventArgs e) {
            Name_RealTime.Text = txtPlayerName.Text;
            line_type.Width = 13 * txtPlayerName.Text.Length;
            pictureBox_Character.Image = (txtPlayerName.Text.Length == 8) ? PlayerImage.RunDown : PlayerImage.Idle;
            #region Validate Username prompt
            // Check fill compete to 8 charater
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
            // Check Thai language
            if (UsernameValidate.CheckTHLang(txtPlayerName.Text)) {
                txtPlayerName.Text = "";
                lblWarning_lang.Visible = true;
            }
            else {
                lblWarning_lang.Visible = false;
            }
            #endregion
        }
        #endregion

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
