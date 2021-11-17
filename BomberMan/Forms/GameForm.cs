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
        bool UseBomb = true;
        bool walkAble;
        Bomb bomb;
        Timer Countdown;
        PictureBox tiles;
        string Directions;
        //PictureBox hitbox;
        List<Control> Box;
        int position, size;
        List<Control> Tile;
        List<Control> Wall;
        List<Control> Bombs;
        readonly Timer time = new Timer();
        #region don't forget delete some code here!!
        void Init()
        {

            TileSize = 50;
            this.Focus();
            position = 100;
            size = 750; // 15 x 50  

            CreateMap();
            /*hitbox = new PictureBox()
            {
                Size = new Size(TileSize, TileSize),
                BorderStyle = BorderStyle.Fixed3D
            };
            this.Controls.Add(hitbox);
            map.AddTiles(hitbox);*/
            Bombs = new List<Control>();
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
                else if (items is PictureBox && (string)items.Tag == "Bomb") {
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
            Walls wall = new Walls();
            wall.Create(map,size,TileSize);
            Boxs box = new Boxs();
            box.Create(map, size, TileSize);
            ResizeForm(this, map);
        }
        public Game(string Playername)
        {
            InitializeComponent();
            Init();
            Enemy = new Enemy();
            player = new Player(Playername, map.MapProperties);
            player.Speed = 1;
            player.Mana = 2;
            player.Power = 3;
            Console.WriteLine($"{player.Mana}");
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
                    UseBomb = true;
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
                if (KeyBoard.SpaceBar(e) && (player.Mana>0) && UseBomb)
                {
                    Console.WriteLine($"{player.Mana}");
                    UseBomb = false;
                    bomb = new Bomb(map,TileSize,player);
                    player.Mana -= 1;
                    Tile.Add(bomb.GetBomb());
                    Countdown = new Timer() {Interval = 1000 };
                    Countdown.Tick += BombActivitor;
                    Countdown.Start();
                }
            }
        }
        private void BombActivitor(object sender, EventArgs a)
        {
            bomb.BombActive(map,player,Tile);
            player.Mana += 1;
            UseBomb = true;
            Countdown.Stop();
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
