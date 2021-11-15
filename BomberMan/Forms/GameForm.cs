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
        List<Control> Tile;
        Map map;
        PictureBox tiles;
        Player player; Enemy Enemy;
        string Directions;
        bool walkAble;
        int position, size;
        int TileSize;
        int steps;
        public Game(string Playername)
        {
            InitializeComponent();
            Init();
            Enemy = new Enemy();
            player = new Player(Playername, map.MapProperties);
            player.Speed = 10;
        }

        void Init()
        {
            TileSize = 50;
            this.Focus();
            position = 100;
            size = 500;
            CreateMap();
            Box = new List<Control>();
            Wall = new List<Control>();
            Tile = new List<Control>();
            foreach (Control items in this.Controls)
            {
                if (items is PictureBox && (string)items.Tag == "Wall")
                {
                    Wall.Add(items);
                    Tile.Add(items);
                }
                else if (items is PictureBox && (string)items.Tag == "Box")
                {
                    Box.Add(items);
                    Tile.Add(items);
                }
            }
            // The duration of creating a loop, where 1000 is 1 second. and every Interval will do update
            time.Interval = 35;
            time.Tick += Update;
            time.Start();

        }
        void ResizeForm(Form BrforeFormResize, Map AfterFormResize)
        {
            int x = AfterFormResize.MapProperties.Location.X - BrforeFormResize.Location.X;
            int y = AfterFormResize.MapProperties.Location.Y - BrforeFormResize.Location.Y;
            while (AfterFormResize.MapProperties.Width % 10 != 0)
            {
                AfterFormResize.MapProperties.Width += 1;
            }
            while (AfterFormResize.MapProperties.Height % 10 != 0)
            {
                AfterFormResize.MapProperties.Height += 1;
            }
            while ((BrforeFormResize.Width < AfterFormResize.MapProperties.Width + x))
            {
                BrforeFormResize.Width += 1;
            }
            while ((BrforeFormResize.Height < AfterFormResize.MapProperties.Height + y))
            {
                BrforeFormResize.Height += 1;
            }
            Console.WriteLine($"{AfterFormResize.MapProperties.Location.X - BrforeFormResize.Location.X }");
            Console.WriteLine($"{AfterFormResize.MapProperties.Location.Y - BrforeFormResize.Location.Y }");
            Console.WriteLine($"{ BrforeFormResize.Height - AfterFormResize.MapProperties.Height}");
            Console.WriteLine($"{ BrforeFormResize.Width - AfterFormResize.MapProperties.Width}");
            Console.WriteLine($"{BrforeFormResize.Width} :{ AfterFormResize.MapProperties.Width}");
            Console.WriteLine($"{BrforeFormResize.Height} :{ AfterFormResize.MapProperties.Height}");
        }
        void CreateMap()
        {
            map = new Map(DecorateImage.Blackboard, new Size(size, size), new Point(position, position));
            for (int i = 1; i < 5; i++)
            {
                tiles = new PictureBox()
                {
                    Size = new Size(50, 50),
                    Location = new Point(i * 100, i * 100),
                    Tag = "Wall",
                    Image = MapImage.box,
                    SizeMode = PictureBoxSizeMode.Zoom,
                };
                map.AddTiles(tiles);
            }
            map.Add(this);
            ResizeForm(this, map);
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (player.WalkFinish)
            {
                if ((e.KeyCode == Keys.D || e.KeyCode == Keys.Right))
                {
                    Directions = "Right";
                    walkAble = true;
                    player.WalkFinish = false;
                    steps = TileSize;
                }
                if (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)
                {
                    Directions = "Left";
                    walkAble = true;
                    player.WalkFinish = false;
                    steps = TileSize;
                }
                if (e.KeyCode == Keys.W || e.KeyCode == Keys.Up)
                {
                    Directions = "Up";
                    walkAble = true;
                    player.WalkFinish = false;
                    steps = TileSize;
                }
                if (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)
                {
                    Directions = "Down";
                    walkAble = true;
                    player.WalkFinish = false;
                    steps = TileSize;
                }
            }
        }

        void Update(object sender, EventArgs a)
        {
            //Point location;
            #region check
            /*
            if (Directions == "Right")
            {
                location = new Point(player.Location.X + TileSize, player.Location.Y);
                foreach (var items in Tile)
                {
                    if (location == items.Location)
                    {
                        walkAble = false;
                    }
                }
            }
            else if (Directions == "Left")
            {
                location = new Point(player.Location.X - TileSize, player.Location.Y);
                foreach (var items in Tile)
                {
                    if (location == items.Location)
                    {
                        walkAble = false;
                    }
                }
            }
            else if (Directions == "Up")
            {
                location = new Point(player.Location.X, player.Location.Y + TileSize);
                foreach (var items in Tile)
                {
                    if (location == items.Location)
                    {
                        walkAble = false;
                    }
                }
            }
            else if (Directions == "Down")
            {
                location = new Point(player.Location.X, player.Location.Y - TileSize);
                foreach (var items in Tile)
                {
                    if (location == items.Location)
                    {
                        walkAble = false;
                    }
                }
            }
            */

            #endregion
            if (walkAble)
            {
                if (steps > 0)
                {
                    player.Move(Directions);
                    steps -= player.Speed;
                }
                else
                {
                    player.WalkFinish = true;
                    Directions = "";
                    walkAble = false;
                }
            }
            player.AnimationDirector = Directions;
        }

    }
}
