using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BomberMan {
    public partial class RegisterForm : Form {
        private int lineSpeed = 10;
        private bool focus;
        public RegisterForm() {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 255, 255);
            btn_Play.BackColor = Color.FromArgb(255, 181, 107);
            Name_RealTime.ForeColor = Color.White;
            pictureBox_Character.Image = Image.FromFile(Path.GetFullPath("..\\..\\resource\\Character\\Player\\student_idle.gif"));
            pictureBox1.Image = Image.FromFile(Path.GetFullPath("..\\..\\resource\\Logo\\Blackboard.jpg"));
            pictureBox1.Controls.Add(pictureBox_Character);
            pictureBox1.Controls.Add(Name_RealTime);
            pictureBox_Character.Location = new Point(100, 70);
            pictureBox_Character.BringToFront();
            Name_RealTime.Location = new Point(75, 40);
            Name_RealTime.BringToFront();
        }



        // ----------------
        // ANIMATION BUTTON
        // ----------------
        private void timer_animation_Tick(object sender, EventArgs e) {
            if (focus) {
                if (lineSlide.Location.X <= 400) {
                    lineSlide.Left += lineSpeed;
                }
            }
        }

        private void txtPlayerName_MouseClick(object sender, MouseEventArgs e) {
            focus = true;
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e) {
            Name_RealTime.Text = txtPlayerName.Text;

            line_type.Width = 13* txtPlayerName.Text.Length;

            if (txtPlayerName.Text.Length == 8) {
                pictureBox_Character.Image = Image.FromFile(Path.GetFullPath("..\\..\\resource\\Character\\Player\\student_run_down.gif"));
            }
            else {
                pictureBox_Character.Image = Image.FromFile(Path.GetFullPath("..\\..\\resource\\Character\\Player\\student_idle.gif"));
            }
        }
        // 255, 192, 128
        private void btn_Play_MouseHover(object sender, EventArgs e) {
            btn_Play.BackColor = Color.FromArgb(255, 192, 128);
        }

        private void btn_Play_MouseLeave(object sender, EventArgs e) {
            btn_Play.BackColor = Color.FromArgb(255, 181, 107);

        }

        private void btn_Play_MouseClick(object sender, MouseEventArgs e) {
            btn_Play.BackColor = Color.FromArgb(255, 159, 64);
        }

        private void btn_Play_MouseDown(object sender, MouseEventArgs e) {
            btn_Play.BackColor = Color.FromArgb(255, 159, 64);
        }
    }
}
