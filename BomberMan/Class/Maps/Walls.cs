using System;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    class Walls
    {
        PictureBox Wall;

        private void LeftWall(int i)
        {
            Wall = new PictureBox()
            {
                Size = Storages.TileSize,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = MapImage.Wall,
                Tag = "Wall",
                Location = new Point(0, Storages.IntegerTileSize * ((i - 1) / ((Storages.IntegerSize / Storages.IntegerTileSize) - 1))),
            };
            AddWall(Wall);
        }
        private void RigthWall(int i)
        {
            Wall = new PictureBox()
            {
                Size = Storages.TileSize,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = MapImage.Wall,
                Tag = "Wall",
                Location = new Point(((Storages.IntegerSize / Storages.IntegerTileSize) - 1) * Storages.IntegerTileSize, Storages.IntegerTileSize * ((i - 1) / ((Storages.IntegerSize / Storages.IntegerTileSize) - 1))),
            };
            AddWall(Wall);
        }
        private void TopWall(int i)
        {
            Wall = new PictureBox()
            {
                Size = Storages.TileSize,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = MapImage.Wall,
                Tag = "Wall",
                Location = new Point(i * Storages.IntegerTileSize, i / ((Storages.IntegerSize / Storages.IntegerTileSize) - 1)),
            };
            AddWall(Wall);
        }
        private void BottomWall(int i)
        {
            Wall = new PictureBox()
            {
                Size = Storages.TileSize,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = MapImage.Wall,
                Tag = "Wall",
                Location = new Point(Storages.IntegerTileSize * ((i - 1) % ((Storages.IntegerSize / Storages.IntegerTileSize) - 1)), ((Storages.IntegerSize / Storages.IntegerTileSize) - 1) * Storages.IntegerTileSize),
            };
            AddWall(Wall);
        }
        private void AddWall(PictureBox tiles)
        {
            tiles.BringToFront();
            Storages.Map.AddTiles(tiles);
        }
        public void Create()
        {
            for (int i = 0; i < Math.Pow((Storages.IntegerSize / Storages.IntegerTileSize), 2);)
            {
                if (i / ((Storages.IntegerSize / Storages.IntegerTileSize) - 1) <= 1 && i != (Storages.IntegerSize / Storages.IntegerTileSize))
                {
                    TopWall(i);
                    i++;
                }
                else if ((i - 1) % ((Storages.IntegerSize / Storages.IntegerTileSize) - 1) == 0 && i < (Math.Pow((Storages.IntegerSize / Storages.IntegerTileSize), 2) - ((Storages.IntegerSize / Storages.IntegerTileSize) - 1)))
                {
                    LeftWall(i);
                    i += (Storages.IntegerSize / Storages.IntegerTileSize) -2;
                }
                else if (i % ((Storages.IntegerSize / Storages.IntegerTileSize) - 1) == 0 && i != (Math.Pow((Storages.IntegerSize / Storages.IntegerTileSize), 2) - 1))
                {
                    RigthWall(i);
                    i++;
                }
                else if (i >= (Math.Pow((Storages.IntegerSize / Storages.IntegerTileSize), 2) - ((Storages.IntegerSize / Storages.IntegerTileSize) - 1)))
                {
                    BottomWall(i);
                    i++;
                }
            }
        }
    }
}
