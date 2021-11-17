using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    class Fires
    {
        private PictureBox fire;
        List<Control> Fire;
        public Fires()
        {
            Fire = new List<Control>();
        }
        public void Up(Map map, Point bomb, int power, int TileSize)
        {
            while (power > 0)
            {
                fire = new PictureBox()
                {
                    Size = new Size(TileSize, TileSize),
                    Location = new Point(bomb.X, bomb.Y - TileSize),
                    Image = Images.Fire,
                    SizeMode = PictureBoxSizeMode.Zoom,
                };
                Fire.Add(fire);
                map.AddTiles(fire);
                power--;
                Up(map, fire.Location, power, TileSize);
            }
        }
        public void Left(Map map, Point bomb, int power, int TileSize)
        {
            while (power > 0)
            {
                fire = new PictureBox()
                {
                    Size = new Size(TileSize, TileSize),
                    Location = new Point(bomb.X - TileSize, bomb.Y),
                    Image = Images.Fire,
                    SizeMode = PictureBoxSizeMode.Zoom,
                };
                Fire.Add(fire);
                map.AddTiles(fire);
                power--;
                Left(map, fire.Location, power, TileSize);
            }
        }
        public void Down(Map map, Point bomb, int power, int TileSize)
        {
            while (power > 0)
            {
                fire = new PictureBox()
                {
                    Size = new Size(TileSize, TileSize),
                    Location = new Point(bomb.X, bomb.Y + TileSize),
                    Image = Images.Fire,
                    SizeMode = PictureBoxSizeMode.Zoom,
                };
                Fire.Add(fire);
                map.AddTiles(fire);
                power--;
                Down(map, fire.Location, power, TileSize);
            }
        }
        public void Right(Map map, Point bomb, int power, int TileSize)
        {
            while (power > 0)
            {
                fire = new PictureBox()
                {
                    Size = new Size(TileSize, TileSize),
                    Location = new Point(bomb.X + TileSize, bomb.Y),
                    Image = Images.Fire,
                    SizeMode = PictureBoxSizeMode.Zoom,
                };
                Fire.Add(fire);
                map.AddTiles(fire);
                power--;
                Right(map, fire.Location, power, TileSize);
            }
        }
        public void DeleteFire()
        {
            Fire.ForEach((fires) => fires.Visible = false) ;
        }
    }
}
