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

namespace BomberMan
{
    public partial class MainForm : Form
    {

        Thread worker;
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenGameForm(object sender, EventArgs e)
        {
            Game GameForm = new Game();
            GameForm.Show();
            this.Hide();
        }

        private void CloseForm(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Setup(object sender, EventArgs e)
        {
            worker = new Thread(BomberMan.Class.SoundEffect.Effects);
            BomberMan.Class.SoundEffect.BGM_Play();
        }

        private void Play_Effect(object sender, EventArgs e)
        {
            worker = new Thread(BomberMan.Class.SoundEffect.Effects);
            worker.Start();
        }
    }
}
