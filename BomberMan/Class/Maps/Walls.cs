using System;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    class Walls
    {
        PictureBox Wall;

        private void LeftWall(Map map, int size, int TileSize, int i)
        {
            Wall = new PictureBox()
            {
                Size = new Size(TileSize, TileSize),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = MapImage.Wall,
                Tag = "Wall",
                Location = new Point(0, TileSize * ((i - 1) / ((size / TileSize) - 1))),
            };
            AddWall(Wall, map);
        }
        private void RigthWall(Map map, int size, int TileSize, int i)
        {
            Wall = new PictureBox()
            {
                Size = new Size(TileSize, TileSize),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = MapImage.Wall,
                Tag = "Wall",
                Location = new Point(((size / TileSize) - 1) * TileSize, TileSize * ((i - 1) / ((size / TileSize) - 1))),
            };
            AddWall(Wall, map);
        }
        private void TopWall(Map map, int size, int TileSize, int i)
        {
            Wall = new PictureBox()
            {
                Size = new Size(TileSize, TileSize),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = MapImage.Wall,
                Tag = "Wall",
                Location = new Point(i * TileSize, i / ((size / TileSize) - 1)),
            };
            AddWall(Wall, map);
        }
        private void BottomWall(Map map, int size, int TileSize, int i)
        {
            Wall = new PictureBox()
            {
                Size = new Size(TileSize, TileSize),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = MapImage.Wall,
                Tag = "Wall",
                Location = new Point(TileSize * ((i - 1) % ((size / TileSize) - 1)), ((size / TileSize) - 1) * TileSize),
            };
            AddWall(Wall, map);
        }
        private void AddWall(PictureBox tiles, Map map)
        {
            tiles.BringToFront();
            map.AddTiles(tiles);
        }
        public void Create(Map map, int size, int TileSize)
        {
            for (int i = 0; i < Math.Pow((Storages.IntegerSize / Storages.IntegerTileSize), 2);)
            {
                if (i / ((Storages.IntegerSize / TileSize) - 1) <= 1 && i != (Storages.IntegerSize / Storages.IntegerTileSize))
                {
                    TopWall(map, Storages.IntegerSize, Storages.IntegerTileSize, i);
                    i++;
                }
                else if ((i - 1) % ((Storages.IntegerSize / Storages.IntegerTileSize) - 1) == 0 && i < (Math.Pow((Storages.IntegerSize / Storages.IntegerTileSize), 2) - ((Storages.IntegerSize / Storages.IntegerTileSize) - 1)))
                {
                    LeftWall(map, Storages.IntegerSize, Storages.IntegerTileSize, i);
                    i += (Storages.IntegerSize / Storages.IntegerTileSize) -2;
                }
                else if (i % ((Storages.IntegerSize / Storages.IntegerTileSize) - 1) == 0 && i != (Math.Pow((Storages.IntegerSize / Storages.IntegerTileSize), 2) - 1))
                {
                    RigthWall(map, Storages.IntegerSize, Storages.IntegerTileSize, i);
                    i++;
                }
                else if (i >= (Math.Pow((Storages.IntegerSize / Storages.IntegerTileSize), 2) - ((Storages.IntegerSize / Storages.IntegerTileSize) - 1)))
                {
                    BottomWall(map, Storages.IntegerSize, Storages.IntegerTileSize, i);
                    i++;
                }
            }
        }
    }
}
