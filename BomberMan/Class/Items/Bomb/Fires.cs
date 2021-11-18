using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    class Fires
    {
        private PictureBox fire;
        public Fires(Point bomb)
        {
            Up(bomb);
            Down(bomb);
            Left(bomb);
            Right(bomb);
        }
        public void Up(Point bomb)
        {

            fire = new PictureBox()
            {
                Size = Storages.TileSize,
                Location = new Point(bomb.X, bomb.Y - Storages.IntegerTileSize),
                Image = Images.Fire,
                SizeMode = PictureBoxSizeMode.Zoom,
            };
            Storages.Map.AddTiles(fire);
            Control Tempbox = new Control();
            bool delete = false;
            bool CanCreateNewFire = true;
            Items Tempitem = new Items();
            bool deleteItem = false;
            Storages.Items.ForEach((item) =>
            {
                if (item.Location == fire.Location)
                {
                    Tempitem = item;
                    CanCreateNewFire = false;
                    deleteItem = true;
                    Storages.Map.DeleteTile(item.Image);
                    RandomItems.Randomitem();
                }
            });
            
            if (!deleteItem) 
            {
                Storages.Boxs.ForEach((box) =>
                {
                    if (box.Location == fire.Location)
                    {
                        Tempbox = box;
                        CanCreateNewFire = false; 
                        delete = true;
                        Storages.Map.DeleteTile(box);
                        Storages.Tiles.Remove(box);
                        Storages.LocationItemRandom.Add(box.Location);
                        RandomItems.Randomitem();
                    }
                });
            }
            
            Storages.Fires.Add(fire);
            if (deleteItem)
            {
                Storages.Items.Remove(Tempitem);
                Storages.Map.DeleteTile(Tempitem.Image);
            }
            else if (delete)
            {
                Storages.Boxs.Remove(Tempbox);
            }
            else if (Storages.Player.Power > 1 && CanCreateNewFire)
            {
                Storages.Player.Power -= 1;
                System.Console.WriteLine("test");
                Up(fire.Location);
                Storages.Player.Power += 1;
            }
        }
        public void Left(Point bomb)
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
            Items Tempitem = new Items();
            bool deleteItem = false;
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

            Storages.Items.ForEach((item) =>
            {
                if (item.Location == fire.Location)
                {
                    Tempitem = item;
                    deleteItem = true;
                    Storages.Map.DeleteTile(item.Image);
                    RandomItems.Randomitem();
                }
            });
            if (deleteItem)
            {
                Storages.Items.Remove(Tempitem);
                Storages.Map.DeleteTile(Tempitem.Image);
            }
            Storages.Fires.Add(fire);
            Storages.Map.AddTiles(fire);
            if (delete)
            {
                Storages.Boxs.Remove(Tempbox);
            }
            if (Storages.Player.Power > 1 && !delete)
            {
                Storages.Player.Power -= 1;
                Left(fire.Location);
                Storages.Player.Power += 1;
            }

        }
        public void Down(Point bomb)
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
            Items Tempitem = new Items();
            bool deleteItem = false;
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

            Storages.Items.ForEach((item) =>
            {
                if (item.Location == fire.Location)
                {
                    Tempitem = item;
                    deleteItem = true;
                    Storages.Map.DeleteTile(item.Image);
                    RandomItems.Randomitem();
                }
            });

            if (deleteItem)
            {
                Storages.Items.Remove(Tempitem);
                Storages.Map.DeleteTile(Tempitem.Image);
            }
            Storages.Fires.Add(fire);
            Storages.Map.AddTiles(fire);
            if (delete)
            {
                Storages.Boxs.Remove(Tempbox);
            }
            if (Storages.Player.Power > 1 && !delete)
            {
                Storages.Player.Power -= 1;
                Down(fire.Location);
                Storages.Player.Power += 1;
            }

        }
        public void Right(Point bomb)
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
            Items Tempitem = new Items();
            bool deleteItem = false;
            Storages.Items.ForEach((item) =>
            {
                if (item.Location == fire.Location)
                {
                    Tempitem = item;
                    deleteItem = true;
                    Storages.Map.DeleteTile(item.Image);
                    RandomItems.Randomitem();
                    return;
                }
            });
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
                        return;
                    }
                });

            if (deleteItem)
            {
                Storages.Items.Remove(Tempitem);
                Storages.Map.DeleteTile(Tempitem.Image);
            }
            Storages.Fires.Add(fire);
            Storages.Map.AddTiles(fire);
            if (delete)
            {
                Storages.Boxs.Remove(Tempbox);
            }
            if (Storages.Player.Power > 1 && !delete)
            {
                Storages.Player.Power -= 1;
                Right(fire.Location);
                Storages.Player.Power += 1;
            }

        }
        public void DeleteFire()
        {
            Storages.Fires.ForEach((fires) => Storages.Map.DeleteTile(fires));
            Storages.Fires.Clear();
        }
    }
}
