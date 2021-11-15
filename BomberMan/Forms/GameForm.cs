﻿using System;
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
        PictureBox hitbox;
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
            size = 500;
            hitbox = new PictureBox()
            {
                Size = new Size(TileSize, TileSize),
                BorderStyle = BorderStyle.Fixed3D
            };
            this.Controls.Add(hitbox);
            CreateMap();
            map.AddTiles(hitbox);
            
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
            time.Interval = 35;
            time.Tick += Update;
            time.Start();
        }
        #endregion
        private void CreateMap()
        {
            map = new Map(DecorateImage.Blackboard, new Size(size, size), new Point(position, position));
            for (int i = 1; i < 5; i++)
            {
                tiles = new PictureBox()
                {
                    Size = new Size(50, 50),
                    Location = new Point(i * 100, i * 100),
                    Tag = "Wall",
                    Image = MapImage.Wall,
                    SizeMode = PictureBoxSizeMode.Zoom,
                };
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
                map.AddTiles(tiles);
            }
            map.Add(this);
            //ResizeForm(this, map);
        }
        public Game(string Playername)
        {
            InitializeComponent();
            Init();
            Enemy = new Enemy();
            player = new Player(Playername, map.MapProperties);
            player.Speed = 1;
        }
        private void Update(object sender, EventArgs a)
        {

            Point location = new Point(0,0);
            hitbox.BackColor = Color.Red;
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
            hitbox.Location = location;
            Tile.ForEach((boxs) =>
            {
                if (location == boxs.Location)
                {
                    walkAble = false;
                    player.WalkFinish = true;
                }
            });
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
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            /*if ((e.KeyCode == Keys.D || e.KeyCode == Keys.Right) || (e.KeyCode == Keys.S || e.KeyCode == Keys.Down)|| (e.KeyCode == Keys.A || e.KeyCode == Keys.Left)|| (e.KeyCode == Keys.W || e.KeyCode == Keys.Up))
            {
                Directions = "";
            }*/
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
        private void ResizeForm(Form BrforeFormResize, Map AfterFormResize)
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
    }
}
