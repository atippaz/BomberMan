using System;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;

namespace BomberMan {
    public partial class StateForm : Form {
        #region Fields
        private int lineSpeed = 12;
        private Thread _Fx;
        #endregion

        public StateForm() {
            InitializeComponent();
            this.Icon = new Icon(Images.IconGame);
            LineSlide1.BackColor = Colors.OrangeLine;
            LineSlide2.BackColor = Colors.PurpleLine;
            if (GameData.WinState)
            {
                Storages.Player.Score *= 2;
            }
            else
            {
                Storages.Player.Score /= 2;
            }
            ShowAllScore();
            ShowWinOrOver(GameData.WinState);
            if (CheckHightScore()) Encryption.Encrypt(GameData.CurrUsername, $"{GameData.CurrScore}");
        }

        #region Methods
        private void ShowWinOrOver(bool win) {
            lblState.Text = (win) ? "GAME WIN" : "GAME OVER";
            pictureBox_StateGame.Image = (win) ? Images.WinState : Images.LoseState;
        }
        private bool CheckHightScore() {
            bool canWrite = (Encryption.HightScore < GameData.CurrScore) ? true : false;
            return canWrite;
        }
        private void ShowAllScore() {
            lblHighScore.Text = $"{Encryption.HightScore}";
            lblScore.Text = $"{Storages.Player.Score}";
        }
        #endregion



        #region RESTART BUTTON
        #region Attribute of START BUTTON
        private bool leaveRestart = false;
        private bool hoverRestart = false;
        #endregion
        private void btnRestart_Click(object sender, EventArgs e) {
            BackGroundMusic.Stop();

            // TEST USERNAME
            Game GameForm = new Game("");
            this.Hide();
            GameForm.Show();
        }
        private void btnRestart_MouseHover(object sender, EventArgs e) {
            hoverRestart = true;
            leaveRestart = false;
        }

        private void btnRestart_MouseLeave(object sender, EventArgs e) {
            btnRestart.BackColor = Colors.OrangeLeave;
            hoverRestart = false;
            leaveRestart = true;
        }

        private void btnRestart_MouseDown(object sender, MouseEventArgs e) {
            btnRestart.BackColor = Colors.OrangeClick;
        }

        private void btnRestart_MouseClick(object sender, MouseEventArgs e) {
            btnRestart.BackColor = Colors.OrangeClick;
        }
        #endregion



        #region MENU BUTTON
        #region Attribute of MENU BUTTON
        private bool leaveMenu = false;
        private bool hoverMenu = false;
        #endregion

        private void btnMenu_Click(object sender, EventArgs e) {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }
        private void btnMenu_MouseLeave(object sender, EventArgs e) {
            btnMenu.BackColor = Colors.GreyLeave;
            hoverMenu = false;
            leaveMenu = true;
        }
        private void btnMenu_MouseHover(object sender, EventArgs e) {
            hoverMenu = true;
            leaveMenu = false;
        }
        private void btnMenu_MouseDown(object sender, MouseEventArgs e) {
            btnMenu.BackColor = Colors.GreyClick;
        }
        #endregion

        #region ANIMATION FOR BUTTON
        private void timer_Animation_Tick(object sender, EventArgs e) {
            if (LineSlide1.Width < btnRestart.Width - 4 && hoverRestart) {
                LineSlide1.Width += lineSpeed;
            }
            else if (LineSlide1.Width > 0 && leaveRestart) {
                LineSlide1.Width -= lineSpeed;
            }
            if (LineSlide2.Width < btnMenu.Width - 6 && hoverMenu) {
                LineSlide2.Width += lineSpeed;
            }
            else if (LineSlide2.Width > 0 && leaveMenu) {
                LineSlide2.Width -= lineSpeed;
            }
        }

        #endregion

        private void StateForm_FormClosed(object sender, FormClosedEventArgs e) {
            Application.Exit();
        }

        private void StateForm_Load(object sender, EventArgs e) {
            BackGroundMusic.Set(Music.OverTheme);
            BackGroundMusic.Play();
            pictureBox_PlayerFace.Image = Images.PlayerState;
            pictureBox_BestPlayerFace.Image = Images.BestPlayerState;

            lblBestPlayerName.Text = (Encryption.Username == "") ? Encryption.Username : "-";           
            lblPlayerName.Text = GameData.CurrUsername;
        }
    }
}
