using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BomberMan
{
    class Bomb
    {
        PictureBox bombs;
        Timer BombTime;
        Timer Time;
        Map map;
        Player player;
        int size;
        Fires fires;
        int power;
        public Bomb(Map map,int TileSize, Player player)
        {
            bombs = new PictureBox()
            {
                Image = MapImage.Bomb,
                Size = new Size (TileSize, TileSize),
                Location = player.Location,
                Tag = "Bomb",
                SizeMode = PictureBoxSizeMode.Zoom
            };
            map.AddTiles(bombs);
            size = TileSize;
            bombs.BringToFront();
            Time = new Timer();
            Time.Interval = 2000;
            Time.Tick += Remove;
            Time.Start();
        }
        public PictureBox GetBomb()
        {
            return bombs;
        }
        public void BombActive(Map map, Player player, List<Control> Tile)
        {
            this.map = map;
            this.player = player;
            BombTime = new Timer();
            BombTime.Interval = 100;
            BombTime.Tick += BombActivitor;
            BombTime.Start();
            this.map = map;
            this.player = player;
            player.Animation.BringToFront();
            Tile.Remove(bombs);
        }
        private void BombActivitor(object sender, EventArgs a)
        {
            bombs.Image = Images.Fire;
            fires = new Fires();
            fires.Up(map,this.bombs.Location,player.Power,size);
            fires.Down(map, this.bombs.Location, player.Power, size);
            fires.Left(map, this.bombs.Location, player.Power, size);
            fires.Right(map, this.bombs.Location, player.Power, size);
        }
        private void Remove(object sender,EventArgs a)
        {
            fires.DeleteFire();
            map.DeleteTile(bombs);
            BombTime.Stop();
            Time.Stop();
        }
    }
}
