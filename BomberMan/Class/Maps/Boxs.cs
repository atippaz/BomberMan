using System;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan {
    class Boxs {
        PictureBox Box;
        private void AddBox(PictureBox tiles) {
            tiles.BringToFront();
            Storages.Map.AddTiles(tiles);
        }
        private void CreatBox(int x, int y) {
            Box = new PictureBox() {
                Size = Storages.TileSize,
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = MapImage.BookBox,
                Tag = "Box",
                Location = new Point(x, y),
            };
            AddBox(Box);
        }
        public void Create() {
            var rn = new Random();
            int row = 1;
            for (int y = 100; y <= (Storages.IntegerSize - Storages.IntegerTileSize); y += Storages.IntegerTileSize * 2) {
                for (int x = Storages.IntegerTileSize; x < Storages.IntegerTileSize * (Storages.IntegerSize / Storages.IntegerTileSize) - 2; x += 50) {
                    int ran = rn.Next(3);
                    if (ran == 1) x += Storages.IntegerTileSize;
                    if (ran == 2) x += Storages.IntegerTileSize * 2;
                    if (ran == 0) x += Storages.IntegerTileSize * 0;
                    CreatBox(x, y);
                }
                row++;
            }
        }
    }
}

