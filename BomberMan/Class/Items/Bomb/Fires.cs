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
            Storages.Fires.Add(fire);
            
            if (CanIncrease(fire) && (Storages.Player.Power > 1))
            {
                Storages.Player.Power -= 1;
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
            Storages.Map.AddTiles(fire);
            Storages.Fires.Add(fire);
            if (CanIncrease(fire) && (Storages.Player.Power > 1))
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
            Storages.Map.AddTiles(fire);
            Storages.Fires.Add(fire);
            
            if (CanIncrease(fire) && (Storages.Player.Power > 1))
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
            Storages.Map.AddTiles(fire);
            Storages.Fires.Add(fire);
            
            if (CanIncrease(fire) && (Storages.Player.Power > 1))
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
        private bool CanIncrease(PictureBox Fire)
        {
            System.Console.WriteLine("test");
            bool canIncrease = true;
            Items Tempitem = new Items();
            bool isFoundItem = false;
            Control Tempbox = new Control();
            foreach (var item in Storages.Items)
            {
                if (item.Location == Fire.Location)
                {
                    Tempitem = item;
                    isFoundItem = true;
                    canIncrease = false;
                    Storages.Map.DeleteTile(item.Image);
                    RandomItems.Randomitem();
                    break;
                }
            }
            if (!isFoundItem)
            {
                foreach (var tile in Storages.Tiles)
                {
                    if (tile.Location == Fire.Location)
                    {
                        if ((string)tile.Tag == "Box")
                        {
                            Tempbox = tile;
                            Storages.Map.DeleteTile(tile);
                            Storages.LocationItemRandom.Add(tile.Location);
                            RandomItems.Randomitem();
                        }
                        canIncrease = false;
                        break;
                    }

                }
            }
            if (isFoundItem)
            {
                Storages.Items.Remove(Tempitem);
                Storages.Map.DeleteTile(Tempitem.Image);
            }
            else if(!canIncrease)
            {
                Storages.Tiles.Remove(Tempbox);
                Storages.Boxs.Remove(Tempbox);
            }
            return canIncrease;
        }
    }
}
