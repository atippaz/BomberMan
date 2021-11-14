using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
namespace BomberMan
{
    public partial class Game : Form
    {
        readonly Timer time = new Timer();
        List<Control> Box;
        List<Control> Wall;
        Map map; 
        Player player; Enemy Enemy;
        string Directions;
        int position, size;
        public Game(string Playername)
        {
            InitializeComponent();
            Init();
            Enemy = new Enemy();
            player = new Player(Playername,map.MapProperties);
        }

        void Init()
        {
            this.Focus();
            position = 100;
                size = 500;
            CreateMap();
            Box = new List<Control>();
            Wall = new List<Control>();
            foreach (Control items in this.Controls)
            {
                if (items is PictureBox && (string)items.Tag == "Wall")
                {
                    Wall.Add(items);
                }
                else if (items is PictureBox && (string)items.Tag == "Box")
                {
                    Box.Add(items);
                }
            }
            // The duration of creating a loop, where 1000 is 1 second. and every Interval will do update
            time.Interval = 35;
            time.Tick += Update;
            time.Start();

        }
        void ResizeForm(Form BrforeFormResize,Map AfterFormResize) 
        {
            int x = AfterFormResize.MapProperties.Location.X - BrforeFormResize.Location.X;
            int y = AfterFormResize.MapProperties.Location.Y - BrforeFormResize.Location.Y;
            while (AfterFormResize.MapProperties.Width %10 != 0)
            {
                AfterFormResize.MapProperties.Width += 1;
            }
            while (AfterFormResize.MapProperties.Height % 10 != 0)
            {
                AfterFormResize.MapProperties.Height += 1;
            }
            while ( (BrforeFormResize.Width < AfterFormResize.MapProperties.Width + x))
            {
                BrforeFormResize.Width += 1;
            }
            while ((BrforeFormResize.Height < AfterFormResize.MapProperties.Height + y))
            {
                BrforeFormResize.Height += 1;
            }
            Console.WriteLine($"{AfterFormResize.MapProperties.Location.X- BrforeFormResize.Location.X }");
            Console.WriteLine($"{AfterFormResize.MapProperties.Location.Y - BrforeFormResize.Location.Y }");
            Console.WriteLine($"{ BrforeFormResize.Height-AfterFormResize.MapProperties.Height}");
            Console.WriteLine($"{ BrforeFormResize.Width - AfterFormResize.MapProperties.Width}");
            Console.WriteLine($"{BrforeFormResize.Width} :{ AfterFormResize.MapProperties.Width}");
            Console.WriteLine($"{BrforeFormResize.Height} :{ AfterFormResize.MapProperties.Height}");
        }
        void CreateMap() 
        {
            map = new Map(DecorateImage.Blackboard, new Size(size, size),new Point(position,position));
            map.Add(this);
            ResizeForm(this, map);
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right) 
            {
                Directions = "";
            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left) 
            {
                Directions = "";
            }
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up) 
            {
                Directions = "";
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down) 
            {
                Directions = "";
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.Right)
            {
                Directions = "Right";
            }
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
            {
                Directions = "Left";
            }
            if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
            {
                Directions = "Up";
            }
            if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
            {
                Directions = "Down";
            }
        }

        void Update(object sender, EventArgs a)
        {
            player.Move(Directions);
            player.AnimationDirector = Directions;
        }

    }
}
