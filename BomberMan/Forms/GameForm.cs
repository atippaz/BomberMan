using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    public partial class Game : Form
    {
        int steps;
        int TileSize;
        bool UseBomb = true;
        bool walkAble;
        Bomb bomb;
        Timer Countdown;
        string Directions;
        //PictureBox hitbox;
        int position, size;
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
            Storages.Boxs = new List<Control>();
            Storages.Walls = new List<Control>();
            Storages.Tiles = new List<Control>();
            foreach (Control items in Storages.Map.MapProperties.Controls)
            {
                if (items is PictureBox && (string)items.Tag == "Wall")
                {
                    Storages.Walls.Add(items);
                    Storages.Tiles.Add(items);
                }
                else if (items is PictureBox && (string)items.Tag == "Box")
                {
                    Storages.Boxs.Add(items);
                    Storages.Tiles.Add(items);
                }
            }
            // The duration of creating a loop, where 1000 is 1 second. and every Interval will do update
            time.Interval = 10;
            time.Tick += Update;
            time.Start();
        }
        #endregion
        private void CreateMap()
        {
            /*map = new Map(MapImage.TileBlue, new Size(size, size), new Point(position, position), this);*/
            Storages.CreateMap(MapImage.TileBlue, size, position, this);
            Walls wall = new Walls();
            wall.Create(Storages.Map, size, TileSize);
            Boxs box = new Boxs();
            box.Create(Storages.Map, size, TileSize);
            FormEditor.Resize(this);
        }
        public Game(string PlayerName)
        {
            InitializeComponent();
            Init();
            Storages.CreatePlayer(PlayerName);
            Storages.Player.Speed = 50;
            Storages.Player.Mana = 2;
            Storages.Player.Power = 3;
        }
        private void Update(object sender, EventArgs a)
        {

            Point location = new Point(0, 0);
            //hitbox.BackColor = Color.Red;
            #region check
            if (Directions == "Right")
            {
                location = new Point(Storages.Player.Location.X + TileSize, Storages.Player.Location.Y);
            }
            else if (Directions == "Left")
            {
                location = new Point(Storages.Player.Location.X - TileSize, Storages.Player.Location.Y);
            }
            else if (Directions == "Up")
            {
                location = new Point(Storages.Player.Location.X, Storages.Player.Location.Y - TileSize);
            }
            else if (Directions == "Down")
            {
                location = new Point(Storages.Player.Location.X, Storages.Player.Location.Y + TileSize);
            }
            label1.Text = Storages.Player.Location.X.ToString();
            label2.Text = Storages.Player.Location.Y.ToString();
            // hitbox.Location = location;
            //if ((location.X < 0 || location.X > map.MapProperties.Width) || (location.Y < 0 || location.Y > map.MapProperties.Height)) {
            //    walkAble = false;
            //    player.WalkFinish = true;
            //}
            if (walkAble)
            {
                Storages.Tiles.ForEach((boxs) =>
                 {
                     if (location == boxs.Location)
                     {
                         walkAble = false;
                         Storages.Player.WalkFinish = true;
                     }
                 });
            }

            #endregion

            if (walkAble)
            {
                if (steps > 0)
                {
                    Storages.Player.Move(Directions);
                    steps -= Storages.Player.Speed;
                }
                else
                {
                    Storages.Player.WalkFinish = true;
                    walkAble = false;
                    UseBomb = true;
                }
            }
            if (Storages.Player.DirectionPlayer != Directions)
            {
                Storages.Player.AnimationDirector = Directions;
            }
            //buff
            Storages.ItemHasDrop = (Storages.Items.Count != 0) ? true : false;
            if (Storages.ItemHasDrop)
            {
                Items tempItem = new Items();
                Control tempImages = new Control();
                Storages.Items.ForEach((buff) =>
                {
                    if (Storages.Player.Location == buff.Location)
                    {
                        buff.Effect(Storages.Player);
                        tempItem = buff;
                        Storages.ItemImage.ForEach((image) =>
                        {
                            if (buff.Image == image)
                            {
                                image.Visible = false;
                                tempImages = image;
                                EffectSound.Click();
                            }
                        });
                    }
                }
                );
                Storages.Items.Remove(tempItem);
                Storages.ItemImage.Remove(tempImages);
            }
            Player.Text = Storages.Player.ToString();
        }
        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (KeyBoard.CheckAll(e) && (Storages.Player.WalkFinish || walkAble))
            {
                Storages.Player.AnimationDirector = "";
            }
        }
        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (Storages.Player.WalkFinish)
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
                    Storages.Player.WalkFinish = false;
                    steps = TileSize;
                }
                if (KeyBoard.SpaceBar(e) && (Storages.Player.Mana > 0) && UseBomb)
                {
                    Console.WriteLine($"{Storages.Player.Mana}");
                    UseBomb = false;
                    bomb = new Bomb(Storages.Map, TileSize, Storages.Player);
                    Storages.Player.Mana -= 1;
                    Storages.Tiles.Add(bomb.GetBomb());
                    Countdown = new Timer() { Interval = 1000 };
                    Countdown.Tick += BombActivitor;
                    Countdown.Start();
                }
                if (e.KeyCode == Keys.F)
                {
                    Storages.LocationItemRandom.Add(new Point(Storages.Player.Location.X + 50, Storages.Player.Location.Y));
                    RandomItems.Randomitem();
                }
            }
        }
        private void BombActivitor(object sender, EventArgs a)
        {
            bomb.BombActive(Storages.Map, Storages.Player);
            Storages.Player.Mana += 1;
            UseBomb = true;
            Countdown.Stop();
        }
        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
