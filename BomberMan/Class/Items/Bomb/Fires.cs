using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    class Fires
    {
        private PictureBox fire;
        public Fires()
        {
            
        }
        public void Up(Point bomb, int power)
        {
            Console.WriteLine($"{power}");
            int powers = power;
            Console.WriteLine($"{Storages.TileSize}");
            while (powers > 0)
            {
                Console.WriteLine($"{power}");
                fire = new PictureBox()
                {
                    Size = Storages.TileSize,
                    Location = new Point(bomb.X, bomb.Y - Storages.IntegerTileSize),
                    Image = Images.Fire,
                    SizeMode = PictureBoxSizeMode.Zoom,
                };
                Storages.Fires.Add(fire);
                Storages.Map.AddTiles(fire);
                powers--;
                if (power > 1)
                {
                    Up(fire.Location, powers);
                }
            }
        }
        public void Left(Point bomb, int power)
        {
            while (power > 0)
            {
                fire = new PictureBox()
                {
                    Size = Storages.TileSize,
                    Location = new Point(bomb.X - Storages.IntegerTileSize, bomb.Y),
                    Image = Images.Fire,
                    SizeMode = PictureBoxSizeMode.Zoom,
                };
                Storages.Fires.Add(fire);
                Storages.Map.AddTiles(fire);
                power--;
                Left(fire.Location, power);
            }
        }
        public void Down(Point bomb, int power)
        {
            while (power > 0)
            {
                fire = new PictureBox()
                {
                    Size = Storages.TileSize,
                    Location = new Point(bomb.X, bomb.Y + Storages.IntegerTileSize),
                    Image = Images.Fire,
                    SizeMode = PictureBoxSizeMode.Zoom,
                };
                Storages.Fires.Add(fire);
                Storages.Map.AddTiles(fire);
                power--;
                Down(fire.Location, power);
            }
        }
        public void Right(Point bomb, int power)
        {
            while (power > 0)
            {
                fire = new PictureBox()
                {
                    Size = Storages.TileSize,
                    Location = new Point(bomb.X + Storages.IntegerTileSize, bomb.Y),
                    Image = Images.Fire,
                    SizeMode = PictureBoxSizeMode.Zoom,
                };
                Storages.Fires.Add(fire);
                Storages.Map.AddTiles(fire);
                power--;
                Right(fire.Location, power);
            }
        }
        public void DeleteFire()
        {
            Storages.Fires.ForEach((fires) => Storages.Map.DeleteTile(fires)) ;
        }
    }
}
