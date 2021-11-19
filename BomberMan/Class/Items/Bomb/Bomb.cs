using System;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    class Bomb
    {
        PictureBox bombs;

        Timer Time;
        Timer Fire;
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
            Time.Interval = 2500;
            Time.Tick += BombActive;
            Time.Start();
        }
        public void BombActive(object sender, EventArgs a)
        {
            EffectSound.Boom();
            Time.Stop();
            Fire = new Timer();
            bombs.Image = Images.Fire;
            Storages.Fires.Add(bombs);
            Storages.Player.Animation.BringToFront();
            Storages.Tiles.Remove(bombs);
            fires = new Fires(bombs.Location,(string)bombs.Tag);
            Fire.Interval = 500;
            Fire.Tick += Remove;
            Fire.Start();
        }
        private void Remove(object sender, EventArgs a)
        {
            Fire.Stop();
            fires.DeleteFire();
            Storages.Map.DeleteTile(bombs);
            Storages.Player.CanBomb = true;
            Storages.Player.Mana += 1;
        }
    }
}
