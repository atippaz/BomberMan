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
            int powers = power;
            while (powers > 0)
            {
                fire = new PictureBox()
                {
                    Size = Storages.TileSize,
                    Location = new Point(bomb.X, bomb.Y - Storages.IntegerTileSize),
                    Image = Images.Fire,
                    SizeMode = PictureBoxSizeMode.Zoom,
                };
                Control Tempbox = new Control();
                bool delete = false;
                Storages.Boxs.ForEach((box) =>
                {
                    if (box.Location == fire.Location)
                    {
                        Tempbox = box;
                        delete = true;
                        Storages.Map.DeleteTile(box);
                        Storages.Tiles.Remove(box);
                        Storages.LocationItemRandom.Add(box.Location);
                        RandomItems.Randomitem();
                    }
                });
                Storages.Fires.Add(fire);
                Storages.Map.AddTiles(fire);
                powers--;
                if (delete)
                {
                    Storages.Boxs.Remove(Tempbox);
                }
                else if(powers  > 1)
                {
                    Up(fire.Location, powers);
                }
            }
        }
        public void Left(Point bomb, int power)
        {
            int powers = power;
            while (powers > 0)
            {
                fire = new PictureBox()
                {
                    Size = Storages.TileSize,
                    Location = new Point(bomb.X - Storages.IntegerTileSize, bomb.Y),
                    Image = Images.Fire,
                    SizeMode = PictureBoxSizeMode.Zoom,
                };
                Control Tempbox = new Control();
                bool delete = false;
                Storages.Boxs.ForEach((box) =>
                {
                    if (box.Location == fire.Location)
                    {
                        Tempbox = box;
                        delete = true;
                        Storages.Map.DeleteTile(box);
                        Storages.Tiles.Remove(box);
                        Storages.LocationItemRandom.Add(box.Location);
                        RandomItems.Randomitem();
                    }
                });
                Storages.Fires.Add(fire);
                Storages.Map.AddTiles(fire);
                powers--;
                if (delete)
                {
                    Storages.Boxs.Remove(Tempbox);
                }
                else if (powers > 1)
                {
                    Left(fire.Location, powers);
                }
            }
        }
        public void Down(Point bomb, int power)
        {
            int powers = power;
            while (powers > 0)
            {
                fire = new PictureBox()
                {
                    Size = Storages.TileSize,
                    Location = new Point(bomb.X, bomb.Y + Storages.IntegerTileSize),
                    Image = Images.Fire,
                    SizeMode = PictureBoxSizeMode.Zoom,
                };
                Control Tempbox = new Control();
                bool delete = false;
                Storages.Boxs.ForEach((box) =>
                {
                    if (box.Location == fire.Location)
                    {
                        Tempbox = box;
                        delete = true;
                        Storages.Map.DeleteTile(box);
                        Storages.Tiles.Remove(box);
                        Storages.LocationItemRandom.Add(box.Location);
                        RandomItems.Randomitem();
                    }
                });
                Storages.Fires.Add(fire);
                Storages.Map.AddTiles(fire);
                powers--;
                if (delete)
                {
                    Storages.Boxs.Remove(Tempbox);
                }
                else if (powers > 1)
                {
                    Down(fire.Location, powers);
                }
            }
        }
        public void Right(Point bomb, int power)
        {
            int powers = power;
            while (powers > 0)
            {
                fire = new PictureBox()
                {
                    Size = Storages.TileSize,
                    Location = new Point(bomb.X + Storages.IntegerTileSize, bomb.Y),
                    Image = Images.Fire,
                    SizeMode = PictureBoxSizeMode.Zoom,
                };
                Control Tempbox = new Control();
                bool delete = false;
                Storages.Boxs.ForEach((box)=> 
                {
                    if(box.Location == fire.Location)
                    {
                        Tempbox = box;
                        delete = true;
                        Storages.Map.DeleteTile(box);
                        Storages.Tiles.Remove(box);
                        Storages.LocationItemRandom.Add(box.Location);
                        RandomItems.Randomitem();
                    }
                });
                Storages.Fires.Add(fire);
                Storages.Map.AddTiles(fire);
                powers--;
                if (delete)
                {
                    Storages.Boxs.Remove(Tempbox);
                }
                else if (powers > 1)
                {
                    Right(fire.Location, powers);
                }
            }
        }
        public void DeleteFire()
        {
            Storages.Fires.ForEach((fires) => Storages.Map.DeleteTile(fires)) ;
            Storages.Fires.Clear();
        }
    }
}
