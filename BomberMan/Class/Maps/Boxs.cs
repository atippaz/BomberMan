using System;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan {
    class Boxs {
        PictureBox Box;
        private void AddBox(PictureBox tiles, Map map) {
            tiles.BringToFront();
            map.AddTiles(tiles);
        }
        private void CreatBox(Map map, int size, int TileSize, int x, int y) {
            Box = new PictureBox() {
                Size = new Size(TileSize, TileSize),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = MapImage.BookBox,
                Tag = "Box",
                Location = new Point(x, y),
            };
            AddBox(Box, map);
        }
        public void Create(Map map, int size, int TileSize) {
            var rn = new Random();
            int row = 1;
            for (int y = 100; y <= (size - TileSize); y += TileSize * 2) {
                for (int x = TileSize; x < TileSize * (size / TileSize) - 2; x += 50) {
                    int ran = rn.Next(3);
                    if (ran == 1) x += TileSize;
                    if (ran == 2) x += TileSize * 2;
                    if (ran == 0) x += TileSize*0;
                    CreatBox(map, size, TileSize, x, y);
                }
                row++;
            }
        }
    }
}

