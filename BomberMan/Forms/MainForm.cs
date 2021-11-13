using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace BomberMan {
    public partial class MainForm : Form {

        Thread worker;
         
        public MainForm() {
            InitializeComponent();

            // initial value for control
            this.BackColor = label1.BackColor = Colors.White;

            pictureBox_Logo.Image = Image.FromFile(Path.GetFullPath(DecorateImage.LogoGame));
            pictureBox1.Image = PlayerImage.RunLeft;
            pictureBox2.Image = PlayerImage.RunUp;

            pictureBox1.Visible= pictureBox2.Visible = false;
        }

        private void OpenGameForm(object sender, EventArgs e) {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void CloseForm(object sender, EventArgs e) {
            Application.Exit();
        }

        private void Setup(object sender, EventArgs e) {
          worker = new Thread(SoundEffect.Effects);
          SoundEffect.BGM_Play();
        }

        private void Play_Effect(object sender, EventArgs e) {
            worker = new Thread(SoundEffect.Effects);
            worker.Start();
        }

        // ----------------------
        // PROPERTIES FOR BUTTON
        // ----------------------

        private int lineSpeed = 9;

        //--------------
        // START BUTTON 
        //--------------
        #region Attribute of START BUTTON
        private bool leave_btnStart = false;
        private bool hover_btnStart = false;
        #endregion
        private void btn_Start_MouseHover(object sender, EventArgs e) {
            btn_Start.BackColor = Colors.OrangeHover;

            hover_btnStart = true;
            leave_btnStart = false;
        }
        private void btn_Start_MouseLeave(object sender, EventArgs e) {
            btn_Start.BackColor = Colors.OrangeLeave;

            hover_btnStart = false;
            leave_btnStart = true;
        }
        private void btn_Start_MouseDown(object sender, MouseEventArgs e) {
            btn_Start.BackColor = Colors.OrangeClick;
        }
        private void btn_Start_MouseClick(object sender, MouseEventArgs e) {
            btn_Start.BackColor = Colors.OrangeClick;
            btn_Start.Size = new Size(237, 73);
        }

        //--------------
        // EXIT BUTTON 
        //--------------
        #region Attribute of EXIT BUTTON
        private bool leave_btnEXIT = false;
        private bool hover_btnEXIT = false;
        #endregion
        private void btn_EXIT_MouseHover(object sender, EventArgs e) {
            hover_btnEXIT = true;
            leave_btnEXIT = false;
        }
        private void btn_EXIT_MouseLeave(object sender, EventArgs e) {
            btn_EXIT.BackColor = Colors.GreyLeave;
            hover_btnEXIT = false;
            leave_btnEXIT = true;
        }
        private void btn_EXIT_MouseClick(object sender, MouseEventArgs e) {
            btn_EXIT.BackColor = Colors.GreyClick;
        }
        private void btn_EXIT_MouseDown(object sender, MouseEventArgs e) {
            btn_EXIT.BackColor = Colors.GreyClick;
        }

        // ----------------
        // ANIMATION BUTTON
        // ----------------
        private void timer_Animation_Tick(object sender, EventArgs e) {

            if (leave_btnStart) {
                if (lineSlide1.Location.X >= 52) {
                    lineSlide1.Left -= lineSpeed;
                }
                pictureBox1.Visible = false;
            }

            if (hover_btnStart) {
                if (lineSlide1.Location.X < 286) {
                    lineSlide1.Left += lineSpeed;
                }
                pictureBox1.Visible = true;
            }

            if (hover_btnEXIT) {
                if (lineSlide2.Location.X < 286) {
                    lineSlide2.Left += lineSpeed;
                }
                pictureBox2.Visible = true;
            }

            if (leave_btnEXIT) {
                if (lineSlide2.Location.X >= 52) {
                    lineSlide2.Left -= lineSpeed;
                }
                pictureBox2.Visible = false;
            }
        }


    }
}
