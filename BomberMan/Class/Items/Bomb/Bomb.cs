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

        public Bomb(int TileSize)
        {
            bombs = new PictureBox()
            {
                Image = MapImage.Bomb,
                Size = new Size(TileSize, TileSize),
                Location = Storages.Player.Location,
                Tag = "Bomb",
                SizeMode = PictureBoxSizeMode.Zoom
            };
            Storages.Map.AddTiles(bombs);
            size = TileSize;
            Storages.Tiles.Add(bombs);
            bombs.BringToFront();
            Time = new Timer();
            Time.Interval = 1000;
            Time.Tick += BombActive;
            Time.Start();
        }
        public void BombActive(object sender, EventArgs a)
        {
            Time.Stop();
            bombs.Image = Images.Fire;
            Storages.Player.Animation.BringToFront();
            Storages.Tiles.Remove(bombs);
            fires = new Fires(bombs.Location);
            Time.Interval = 500;
            Time.Tick += Remove;
            Time.Start();
        }
        private void Remove(object sender,EventArgs a)
        {
            Time.Stop();
            fires.DeleteFire();
            Storages.Map.DeleteTile(bombs);
            Storages.Player.Mana += 1;
            Storages.Player.CanBomb = true;
        }
    }
}
