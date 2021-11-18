using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    public partial class Game : Form
    {
        int steps;
        bool UseBomb = true;
        bool walkAble;
        string Directions;
        string BotDirections;
        //PictureBox hitbox;
        int position;
        readonly Timer time = new Timer();
        readonly Timer BotTime = new Timer();
        void Init()
        {
            Storages.IntegerTileSize = 50;
            Storages.TileSize = new Size(Storages.IntegerTileSize, Storages.IntegerTileSize);
            this.Focus();
            position = 100;
            Storages.IntegerSize = 750; // 15 x 50  
            Storages.Size = new Size(Storages.IntegerSize, Storages.IntegerSize);
            CreateMap();
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
            BotTime.Interval = 1000;
            BotTime.Tick += RandomMove;
            BotTime.Start();
            time.Interval = 10;
            time.Tick += Update;
            time.Start();
        }
        private void CreateMap()
        {
            /*map = new Map(MapImage.TileBlue, new Size(size, size), new Point(position, position), this);*/
            Storages.CreateMap(MapImage.TileBlue, Storages.IntegerSize, position, this);
            Walls wall = new Walls();
            wall.Create();
            Boxs box = new Boxs();
            box.Create();
            FormEditor.Resize(this);
        }
        public Game(string PlayerName)
        {
            InitializeComponent();
            Init();
            Storages.CreatePlayer();
            Storages.Player.Name = PlayerName;
            Storages.CreateEnemy();
            Storages.Player.Speed = 2;
            Storages.Player.Mana = 3;
            Storages.Player.Power = 1;
        }
        private void RandomMove(object sender, EventArgs a)
        {
            bool botwalk = false;
            int botsteps = 0;
            Random random = new Random();
            int rndMove = random.Next(1, 10);
            if (rndMove > 2)
            {
                if (rndMove > 8)
                {
                    BotDirections = "Rigth";
                }
                else if (rndMove > 6)
                {
                    BotDirections = "Left";
                }
                else if (rndMove > 4)
                {
                    BotDirections = "Up";
                }
                else if (rndMove > 2)
                {
                    BotDirections = "Down";
                }
                botwalk = true;
                Storages.Enemy.WalkFinish = false;
                botsteps = Storages.IntegerTileSize;
                Storages.Enemy.CanBomb = true;
            }
            else
            {
                Storages.Enemy.Planbomb(Storages.Enemy.Location, Storages.Enemy);
            }
            Controllers.walk(BotDirections, botwalk, botsteps, Storages.Enemy.CanBomb, Storages.Enemy);
        }
        private void Update(object sender, EventArgs a)
        {
            if (Storages.Player.HP > 0 && Storages.Enemy.HP > 0)
            {
                Point location = new Point(0, 0);
                //hitbox.BackColor = Color.Red;
                #region check
                if (Directions == "Right")
                {
                    location = new Point(Storages.Player.Location.X + Storages.IntegerTileSize, Storages.Player.Location.Y);
                }
                else if (Directions == "Left")
                {
                    location = new Point(Storages.Player.Location.X - Storages.IntegerTileSize, Storages.Player.Location.Y);
                }
                else if (Directions == "Up")
                {
                    location = new Point(Storages.Player.Location.X, Storages.Player.Location.Y - Storages.IntegerTileSize);
                }
                else if (Directions == "Down")
                {
                    location = new Point(Storages.Player.Location.X, Storages.Player.Location.Y + Storages.IntegerTileSize);
                }
                label1.Text = Storages.Player.Location.X.ToString();
                label2.Text = Storages.Player.Location.Y.ToString();
                Player.Text = Storages.Player.Name;
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
                        Storages.Player.AnimationDirector = "";
                        walkAble = false;
                        UseBomb = true;
                    }
                }
                if (Storages.Player.DirectionPlayer != Directions)
                {
                    Storages.Player.AnimationDirector = Directions;
                }
                //buff check
                Storages.ItemHasDrop = (Storages.Items.Count != 0) ? true : false;
                Storages.Fires.ForEach((fire) =>
                {
                    if (Storages.Player.Location == fire.Location)
                    {
                        Storages.Player.HP -= 1;
                    }
                    else if (Storages.Enemy.Location == fire.Location)
                    {
                        if ((string)fire.Tag == "Player")
                        {
                            Storages.Enemy.HP -= 1;
                        }

                    }
                });
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
            else
            {
                time.Stop();
                BotTime.Stop();
                if (Storages.Player.HP > 0)
                {
                    MessageBox.Show(" Player Win");
                    Storages.Player.Win = true;
                } 
                else 
                {
                    MessageBox.Show("Game Over Enemy Win");
                    Storages.Player.Win = false;
                }

            }
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
                    steps = Storages.IntegerTileSize;
                    Storages.Player.CanBomb = true;
                }
                if (KeyBoard.SpaceBar(e) && (Storages.Player.Mana > 0) && Storages.Player.CanBomb && Storages.Player.HP > 0 && Storages.Enemy.HP > 0)
                {
                    Storages.Player.CanBomb = false;
                    Storages.Player.Mana -= 1;
                    Storages.Player.Planbomb(Storages.Player.Location, Storages.Player);
                }
                if (e.KeyCode == Keys.F)
                {
                    Storages.LocationItemRandom.Add(new Point(Storages.Player.Location.X + 50, Storages.Player.Location.Y));
                    RandomItems.Randomitem();
                }
            }
        }
        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
