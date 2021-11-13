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

namespace BomberMan
{
    public partial class Game : Form
    {
        readonly Timer time = new Timer();
        PictureBox Player;
        Player playerProperties;
        public Game()
        {
            InitializeComponent();
        }
        public Game(string Playername)
        {
            InitializeComponent();
        }

        private void TestBtn(object sender, EventArgs e)
        {
           
        }
        void Init(object sender, EventArgs e)
        {
            this.Focus();
            CreateMap();
            // The duration of creating a loop, where 1000 is 1 second. and every Interval will do update
            time.Interval = 35;
            time.Tick += Update;
            time.Start();

        }
        void CreateMap() { }
        void Update(object sender, EventArgs a)
        {

        }

        private void OpenMainForm(object sender, EventArgs e)
        {
            MainForm form = new MainForm();
            form.Show();
            this.Close();
        }
    }
}
