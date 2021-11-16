using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    public partial class Game : Form
    {
        Map map;
        int steps;
        Enemy Enemy;
        int TileSize;
        Player player;
        bool walkAble;
        PictureBox tiles;
        string Directions;
        //PictureBox hitbox;
        List<Control> Box;
        int position, size;
        List<Control> Tile;
        List<Control> Wall;
        readonly Timer time = new Timer();
        #region don't forget delete some code here!!
        void Init()
        {

            TileSize = 50;
            this.Focus();
            position = 100;
            size = 800; // 16 * 50
            
            CreateMap();
            /*hitbox = new PictureBox()
            {
                Size = new Size(TileSize, TileSize),
                BorderStyle = BorderStyle.Fixed3D
            };
            this.Controls.Add(hitbox);
            map.AddTiles(hitbox);*/

            Box = new List<Control>();
            Wall = new List<Control>();
            Tile = new List<Control>();
            foreach (Control items in map.MapProperties.Controls)
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
                #region delete here !!
                //ลบด้วยใช้ตอนเทสเท่านั้น 
                else if (items is PictureBox && (string)items.Tag == "Bomb")
                {
                    Tile.Add(items);
                }
                #endregion
            }
            // The duration of creating a loop, where 1000 is 1 second. and every Interval will do update
            time.Interval = 10;
            time.Tick += Update;
            time.Start();
        }
        #endregion
        private void CreateMap()
        {
            map = new Map(MapImage.TileBlue, new Size(size, size), new Point(position, position), this);

            for (int i = 1; i < 5; i++)
            {
                tiles = new PictureBox()
                {
                    Size = new Size(50, 50),
                    Location = new Point(i * 100, i * 100),
                    Tag = "Wall",
                    Image = MapImage.BookBox,
                    SizeMode = PictureBoxSizeMode.Zoom,
                };
                tiles.BringToFront();
                map.AddTiles(tiles);
            }
            for (int j = 5; j > 0; j--)
            {
                tiles = new PictureBox()
                {
                    Size = new Size(50, 50),
                    Location = new Point(j * 150, j * 50),
                    Tag = "Box",
                    Image = MapImage.Box,
                    SizeMode = PictureBoxSizeMode.Zoom,
                };
                tiles.BringToFront();
                map.AddTiles(tiles);
            }
            for (int j = 5; j > 0; j--)
            {
                tiles = new PictureBox()
                {
                    Size = new Size(50, 50),
                    Location = new Point(j * 100, j * 50),
                    Tag = "Bomb",
                    Image = MapImage.Bomb,
                    SizeMode = PictureBoxSizeMode.Zoom,
                };
                tiles.BringToFront();
                map.AddTiles(tiles);
            }
            ResizeForm(this, map);
        }
        public Game(string Playername)
        {
            InitializeComponent();
            Init();
            Enemy = new Enemy();
            player = new Player(Playername, map.MapProperties);
            player.Speed = 50;
        }
        private void Update(object sender, EventArgs a)
        {

            Point location = new Point(0, 0);
            //hitbox.BackColor = Color.Red;
            #region check
            if (Directions == "Right")
            {
                location = new Point(player.Location.X + TileSize, player.Location.Y);
            }
            else if (Directions == "Left")
            {
                location = new Point(player.Location.X - TileSize, player.Location.Y);
            }
            else if (Directions == "Up")
            {
                location = new Point(player.Location.X, player.Location.Y - TileSize);
            }
            else if (Directions == "Down")
            {
                location = new Point(player.Location.X, player.Location.Y + TileSize);
            }
            label1.Text = player.Location.X.ToString();
            label2.Text = player.Location.Y.ToString();
            // hitbox.Location = location;
            //if ((location.X < 0 || location.X > map.MapProperties.Width) || (location.Y < 0 || location.Y > map.MapProperties.Height)) {
            //    walkAble = false;
            //    player.WalkFinish = true;
            //}
            if (walkAble)
            {
                Tile.ForEach((boxs) =>
                {
                    if (location == boxs.Location)
                    {
                        walkAble = false;
                        player.WalkFinish = true;
                    }
                });
            }

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
                    walkAble = false;
                }
            }
            if (player.DirectionPlayer != Directions)
            {
                player.AnimationDirector = Directions;
            }
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (KeyBoard.CheckAll(e) && (player.WalkFinish || walkAble))
            {
                player.AnimationDirector = "";
            }
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (player.WalkFinish)
            {
                if (KeyBoard.Right(e))
                {
                    Directions = "Right";
                }
                if (KeyBoard.Left(e))
                {
                    Directions = "Left";
                }
                if (KeyBoard.Up(e))
                {
                    Directions = "Up";
                }
                if (KeyBoard.Down(e))
                {
                    Directions = "Down";
                }
                if (KeyBoard.CheckAll(e))
                {
                    walkAble = true;
                    player.WalkFinish = false;
                    steps = TileSize;
                }
                if (KeyBoard.SpaceBar(e))
                {

                }
            }
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ResizeForm(Form BrforeFormResize, Map AfterFormResize)
        {
            int WidthBF = AfterFormResize.MapProperties.Location.X - BrforeFormResize.Location.X;
            int HeightBF = AfterFormResize.MapProperties.Location.Y - BrforeFormResize.Location.Y;
            int WidthAT = BrforeFormResize.Width;
            int HeightAT = BrforeFormResize.Height;
            if (BrforeFormResize.Size.Width < AfterFormResize.MapProperties.Width || BrforeFormResize.Size.Height < AfterFormResize.MapProperties.Height)
            {
                while ((WidthAT <= AfterFormResize.MapProperties.Width + WidthBF + 120))
                {
                    WidthAT += 1;
                }
                while ((HeightAT <= AfterFormResize.MapProperties.Height + HeightBF + 200))
                {
                    HeightAT += 1;
                }
            }
            else
            {
                while ((WidthAT >= AfterFormResize.MapProperties.Width + WidthBF + 120))
                {
                    WidthAT -= 1;
                }
                while ((HeightAT >= AfterFormResize.MapProperties.Height + HeightBF + 120))
                {
                    HeightAT -= 1;
                }
            }
            BrforeFormResize.Width = WidthAT;
            BrforeFormResize.Height = HeightAT;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
