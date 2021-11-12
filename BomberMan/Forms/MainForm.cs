using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace BomberMan {
    public partial class MainForm : Form {

        Thread worker;
         
        public MainForm() {
            InitializeComponent();
            // initial value for control
            this.BackColor = Color.FromArgb(255, 255, 255);
            label1.BackColor = Color.FromArgb(255, 255, 255);

            pictureBox_Logo.Image = Image.FromFile(Path.GetFullPath("..\\..\\resource\\Logo\\logo.gif"));
            pictureBox1.Image = Image.FromFile(Path.GetFullPath("..\\..\\resource\\Character\\Player\\student_run_left.gif"));
            pictureBox2.Image = Image.FromFile(Path.GetFullPath("..\\..\\resource\\Character\\Player\\student_run_up.gif"));
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
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
          worker = new Thread(BomberMan.Class.SoundEffect.Effects);
          BomberMan.Class.SoundEffect.BGM_Play();
        }

        private void Play_Effect(object sender, EventArgs e) {
            worker = new Thread(BomberMan.Class.SoundEffect.Effects);
            worker.Start();
        }



        // ----------------------
        // PROPERTIES FOR BUTTON
        // ----------------------

        private int lineSpeed = 9;

        //--------------
        // START BUTTON 
        //--------------

        // default:  255, 181, 107
        // hover: 255, 192, 128
        // click: 255, 159, 64

        #region Attribute of START BUTTON
        private bool leave_btnStart = false;
        private bool hover_btnStart = false;
        #endregion
        private void btn_Start_MouseHover(object sender, EventArgs e) {
            btn_Start.BackColor = Color.FromArgb(255, 192, 128);

            hover_btnStart = true;
            leave_btnStart = false;
        }
        private void btn_Start_MouseLeave(object sender, EventArgs e) {
            btn_Start.BackColor = Color.FromArgb(255, 181, 107);

            hover_btnStart = false;
            leave_btnStart = true;
        }
        private void btn_Start_MouseDown(object sender, MouseEventArgs e) {
            btn_Start.BackColor = Color.FromArgb(255, 159, 64);
        }
        private void btn_Start_MouseClick(object sender, MouseEventArgs e) {
            btn_Start.BackColor = Color.FromArgb(255, 159, 64);
            btn_Start.Size = new Size(237, 73);
        }

        //--------------
        // EXIT BUTTON 
        //--------------

        // default:  224, 224, 224
        // click: 208, 208, 205
        #region Attribute of EXIT BUTTON
        private bool leave_btnEXIT = false;
        private bool hover_btnEXIT = false;
        #endregion
        private void btn_EXIT_MouseHover(object sender, EventArgs e) {
            hover_btnEXIT = true;
            leave_btnEXIT = false;
        }
        private void btn_EXIT_MouseLeave(object sender, EventArgs e) {
            btn_EXIT.BackColor = Color.FromArgb(224, 224, 224);
            hover_btnEXIT = false;
            leave_btnEXIT = true;
        }
        private void btn_EXIT_MouseClick(object sender, MouseEventArgs e) {
            btn_EXIT.BackColor = Color.FromArgb(208, 208, 205);
        }
        private void btn_EXIT_MouseDown(object sender, MouseEventArgs e) {
            btn_EXIT.BackColor = Color.FromArgb(208, 208, 205);
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
