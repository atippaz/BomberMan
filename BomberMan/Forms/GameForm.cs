
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan {
    public partial class Game : Form {
        #region variables
        int steps;
        bool UseBomb = true;
        bool walkAble;
        string Directions;
        string BotDirections;
        int minute,second;
        int Position_X,Position_Y;
        readonly Timer time = new Timer();
        readonly Timer BotTime = new Timer();
        readonly Timer TimeGame = new Timer();
        int reset = 0;
        #endregion

        void Init() {
            Encryption.Decrypt();
            Storages.IntegerTileSize = 50;
            Storages.TileSize = new Size(Storages.IntegerTileSize, Storages.IntegerTileSize);
            this.Focus();
            Position_X = Storages.IntegerTileSize * 2;
            Position_Y = Storages.IntegerTileSize * 3;
            Storages.IntegerSize = 750; // 15 x 50  
            Storages.Size = new Size(Storages.IntegerSize, Storages.IntegerSize);
            CreateMap();
            Storages.Boxs = new List<Control>();
            Storages.Walls = new List<Control>();
            Storages.Tiles = new List<Control>();
            foreach (Control items in Storages.Map.MapProperties.Controls) {
                if (items is PictureBox && (string)items.Tag == "Wall") {
                    Storages.Walls.Add(items);
                    Storages.Tiles.Add(items);
                }
                else if (items is PictureBox && (string)items.Tag == "Box") {
                    Storages.Boxs.Add(items);
                    Storages.Tiles.Add(items);
                }
            }
            // The duration of creating a loop, where 1000 is 1 second. and every Interval will do update
            TimeGame.Interval = 1000;
            TimeGame.Tick += Time_Counter;
            TimeGame.Start();
            BotTime.Interval = 1000;
            BotTime.Tick += RandomMove;
            BotTime.Start();
            time.Interval = 10;
            time.Tick += Update;
            time.Start();
        }
        private void CreateMap() {
            Storages.CreateMap(MapImage.TileBlue, Storages.IntegerSize, Position_X,Position_Y, this);
            Walls wall = new Walls();
            wall.Create();
            Boxs box = new Boxs();
            box.Create();
            FormEditor.Resize(this);
        }
        public Game(string PlayerName) {
            InitializeComponent();
            Init();
            Storages.CreatePlayer();
            Storages.Player.Name = PlayerName;
            Storages.CreateEnemy();
            Storages.Player.Speed = 5;
            Storages.Player.Mana = 1;
            Storages.Player.Power = 1;
            lblGameTime.Text = "00 : 00";
            lblScorePlus.Text = "";
            lblScore.Text = "0";
        }
        private void Update(object sender, EventArgs a)
        {
            lblScore.Text = Storages.Player.Score.ToString();
            lblBomb.Text = Storages.Player.Mana.ToString();
            lblPower.Text = Storages.Player.Power.ToString();
            lblSpeed.Text = Storages.Player.Speed.ToString();
            if(Storages.Player.HP >= 3)
            {
                pbHeat1.Image = pbHeat2.Image = pbHeat3.Image = Images.HeartFull;
            }
            else if (Storages.Player.HP >= 2)
            {
                pbHeat1.Image = pbHeat2.Image = Images.HeartFull;
                pbHeat3.Image = Images.HeartEmpty;
            }
            else if (Storages.Player.HP >= 1)
            {
                pbHeat1.Image = Images.HeartFull;
                pbHeat2.Image = pbHeat3.Image = Images.HeartEmpty;
            }
            else
            {
                pbHeat1.Image = pbHeat2.Image = pbHeat3.Image = Images.HeartEmpty;
            }
            if (Storages.Player.HP > 0 && Storages.Enemy.HP > 0)
            {
                Point location = new Point(0, 0);
                //hitbox.BackColor = Color.Red;
                #region check
                if (Directions == "Right") {
                    location = new Point(Storages.Player.Location.X + Storages.IntegerTileSize, Storages.Player.Location.Y);
                }
                else if (Directions == "Left") {
                    location = new Point(Storages.Player.Location.X - Storages.IntegerTileSize, Storages.Player.Location.Y);
                }
                else if (Directions == "Up") {
                    location = new Point(Storages.Player.Location.X, Storages.Player.Location.Y - Storages.IntegerTileSize);
                }
                else if (Directions == "Down") {
                    location = new Point(Storages.Player.Location.X, Storages.Player.Location.Y + Storages.IntegerTileSize);
                }
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
                reset++;
                if(reset >= 50)
                {
                    reset = 0;
                    Storages.Player.CanHitDamage = true;
                }
                if (walkAble) {
                    if (steps > 0) {
                        Storages.Player.Move(Directions);
                        steps -= Storages.Player.Speed;
                    }
                    else {
                        Storages.Player.WalkFinish = true;
                        Storages.Player.AnimationDirector = "";
                        walkAble = false;
                        UseBomb = true;
                    }
                }
                if (Storages.Player.DirectionPlayer != Directions) {
                    Storages.Player.AnimationDirector = Directions;
                }
                //buff check
                Storages.ItemHasDrop = (Storages.Items.Count != 0) ? true : false;
                Storages.Fires.ForEach((fire) => {
                    if (Storages.Player.Location == fire.Location && Storages.Player.CanHitDamage) {
                        Storages.Player.HP -= 1;
                        Storages.Player.CanHitDamage = false;
                        reset = 0;
                    }
                    else if (Storages.Enemy.Location == fire.Location)
                    {
                        if ((string)fire.Tag == "Player")
                        {
                            Storages.Enemy.HP -= 1;
                            Storages.Player.Score += 500;
                        }
                    }
                });
                if (Storages.ItemHasDrop) {
                    Items tempItem = new Items();
                    Control tempImages = new Control();
                    Storages.Items.ForEach((buff) =>
                    {
                        if (Storages.Player.Location == buff.Location)
                        {
                            buff.Effect();
                            Storages.Player.Score += 10;
                            tempItem = buff;
                            Storages.ItemImage.ForEach((image) => {
                                if (buff.Image == image) {
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
                
            }
            else {
                time.Stop();
                BotTime.Stop();
                TimeGame.Stop();
                BackGroundMusic.Stop();
                GameData.WinState = (Storages.Player.HP > 0) ? true : false;
                StateForm stateForm = new StateForm();
                this.Hide();
                stateForm.Show();
            }
        }
        // Sound Background Music
        private void Game_Load(object sender, EventArgs e) {
            pB_Speed.Image = Images.SpeedBootsState;
            pB_Bomb.Image = Images.IncreaseBombState;
            pB_Power.Image = Images.PowerBombState;
            pictureBox_ShowFacePlayer.Image = Images.PlayerState;
            lblShowUsername.Text = GameData.CurrUsername;
            BackGroundMusic.Set(Music.GameTheme);
            BackGroundMusic.Play();
        }
        private void RandomMove(object sender, EventArgs a)
        {
            bool botwalk = false;
            int botsteps = 0;
            Random random = new Random();
            int rndMove = random.Next(1, 10);
            if (rndMove > 3)
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
        private void KeyIsUp(object sender, KeyEventArgs e) {
            if (KeyBoard.CheckAll(e) && (Storages.Player.WalkFinish || walkAble)) {
                Storages.Player.AnimationDirector = "";
            }
        }
        private void Time_Counter(object senfer, EventArgs e)
        {
            second++;
            if (second >= 60)
            {
                minute++;
                second = 0;
            }
           lblGameTime.Text = $"{minute:00} : {second:00} "; 
        }
        private void KeyIsDown(object sender, KeyEventArgs e) {
            if (Storages.Player.WalkFinish) {
                if (KeyBoard.Right(e)) {
                    Directions = "Right";
                }
                if (KeyBoard.Left(e)) {
                    Directions = "Left";
                }
                if (KeyBoard.Up(e)) {
                    Directions = "Up";
                }
                if (KeyBoard.Down(e)) {
                    Directions = "Down";
                }
                if (KeyBoard.CheckAll(e)) {
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

        // Sound Background Music

    }
}
