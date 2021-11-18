using System;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    class Bomb
    {
        PictureBox bombs;
    
        Timer Time;
     
        Fires fires;

        public Bomb(Point location,Characters player)
        {
            bombs = new PictureBox()
            {
                Image = MapImage.Bomb,
                Size = Storages.TileSize,
                Location = location,
                Tag = player.Animation.Tag,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            Storages.Map.AddTiles(bombs);
            Storages.Tiles.Add(bombs);
            bombs.BringToFront();
            Time = new Timer();
            Time.Interval = 2000;
            Time.Tick += BombActive;
            Time.Start();
        }
        public void BombActive(object sender, EventArgs a)
        {
            Time.Stop();
            bombs.Image = Images.Fire;
            Storages.Fires.Add(bombs);
            Storages.Player.Animation.BringToFront();
            Storages.Tiles.Remove(bombs);
            fires = new Fires(bombs.Location,(string)bombs.Tag);
            Time.Interval = 500;
            Time.Tick += Remove;
            Time.Start();
        }
        private void Remove(object sender, EventArgs a)
        {
            Time.Stop();
            fires.DeleteFire();
            Storages.Map.DeleteTile(bombs);
            Storages.Player.Mana += 1;
            Storages.Player.CanBomb = true;
        }
    }
}
