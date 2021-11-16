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
                Image = MapImage.BookBox,
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
                Image = MapImage.BookBox,
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
                Image = MapImage.BookBox,
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
                Image = MapImage.BookBox,
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
            for (int i = 0; i < Math.Pow((size / TileSize), 2); i++)
            {
                if (i / ((size / TileSize) - 1) <= 1 && i != (size / TileSize))
                {
                    TopWall(map, size, TileSize, i);
                }
                else if ((i - 1) % ((size / TileSize) - 1) == 0)
                {
                    LeftWall(map, size, TileSize, i);
                }
                else if (i % ((size / TileSize) - 1) == 0 && i != (Math.Pow((size / TileSize), 2) - 1))
                {
                    RigthWall(map, size, TileSize, i);
                }
                else if (i >= (Math.Pow((size / TileSize), 2) - ((size / TileSize) - 1)))
                {
                    BottomWall(map, size, TileSize, i);
                }
            }
        }
    }
}
