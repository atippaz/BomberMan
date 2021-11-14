using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace BomberMan
{
    public partial class MainForm : Form
    {

        Thread worker;
        PictureBox playerLogo, playerLogo1;
        public MainForm()
        {
            InitializeComponent();
            // initial value for control
            

            pictureBox_Logo.Image = Image.FromFile(Path.GetFullPath(DecorateImage.LogoGame));
            playerLogo = new PictureBox()
            {
                Name = "player",
                Size = new Size(50, 50),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image =  PlayerImage.RunLeft,
                Location = new Point(btn_Start.Location.X - 60, btn_Start.Location.Y + 20),
            };
            playerLogo1 = new PictureBox()
            {
                Name = "player",
                Size = new Size(50, 50),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image =  PlayerImage.RunUp,
                Location = new Point(btn_EXIT.Location.X - 60, btn_EXIT.Location.Y + 20),
            };
            this.Controls.Add(playerLogo1);
            this.Controls.Add(playerLogo);
            playerLogo.Visible = playerLogo1.Visible = false;
        }

        private void OpenGameForm(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
            this.Hide();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Setup(object sender, EventArgs e)
        {
            worker = new Thread(SoundEffect.Effects);
            SoundEffect.BGM_Play();
        }

        private void Play_Effect(object sender, EventArgs e)
        {
            worker = new Thread(SoundEffect.Effects);
            worker.Start();
        }

        // ----------------------
        // PROPERTIES FOR BUTTON
        // ----------------------

        private int lineSpeed = 10;

        //--------------
        // START BUTTON 
        //--------------
        #region Attribute of START BUTTON
        private bool leave_btnStart = false;
        private bool hover_btnStart = false;
        #endregion
        private void btn_Start_MouseHover(object sender, EventArgs e)
        {
            btn_Start.BackColor = Colors.OrangeHover;
            hover_btnStart = true;
            leave_btnStart = false;
        }
        private void btn_Start_MouseLeave(object sender, EventArgs e)
        {
            btn_Start.BackColor = Colors.OrangeLeave;
            hover_btnStart = false;
            leave_btnStart = true;
        }
        private void btn_Start_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Start.BackColor = Colors.OrangeClick;
        }
        private void btn_Start_MouseClick(object sender, MouseEventArgs e)
        {
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
        private void btn_EXIT_MouseHover(object sender, EventArgs e)
        {
            hover_btnEXIT = true;
            leave_btnEXIT = false;
        }
        private void btn_EXIT_MouseLeave(object sender, EventArgs e)
        {
            btn_EXIT.BackColor = Colors.GreyLeave;
            hover_btnEXIT = false;
            leave_btnEXIT = true;
        }
        private void btn_EXIT_MouseClick(object sender, MouseEventArgs e)
        {
            btn_EXIT.BackColor = Colors.GreyClick;
        }
        private void btn_EXIT_MouseDown(object sender, MouseEventArgs e)
        {
            btn_EXIT.BackColor = Colors.GreyClick;
        }

        // ----------------
        // ANIMATION BUTTON
        // ----------------
        private void timer_Animation_Tick(object sender, EventArgs e)
        {
            if (lineSlide1.Width < btn_Start.Width && hover_btnStart)
            {
                lineSlide1.Width += lineSpeed;
                playerLogo.Visible = true;
            }
            else if (lineSlide1.Width > 0 && leave_btnStart)
            {
                lineSlide1.Width -= lineSpeed;
                playerLogo.Visible = false;
            }
            if (lineSlide2.Width < btn_Start.Width && hover_btnEXIT)
            {
                lineSlide2.Width += lineSpeed;
                playerLogo1.Visible = true;
            }
            else if (lineSlide2.Width > 0 && leave_btnEXIT)
            {
                lineSlide2.Width -= lineSpeed;
                playerLogo1.Visible = false;
            }
        }
    }
}
