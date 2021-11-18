using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan {
    static class Storages {
        public static List<Control> Walls = new List<Control>();
        public static List<Control> Tiles = new List<Control>();
        public static List<Control> Boxs = new List<Control>();
        public static List<Control> Bombs = new List<Control>();
        public static List<Control> Fires = new List<Control>();
        public static List<Control> ItemImage = new List<Control>();
        public static List<Items> Items = new List<Items>();
        public static List<Point> LocationItemRandom = new List<Point>();
        public static Map Map;
        public static Size TileSize;
        public static int IntegerTileSize;
        public static Size Size;
        public static int IntegerSize;

        public static Player Player;
        public static Enemy Enemy;
        public static bool ItemHasDrop = false;
        public static void CreateMap(Image image,int size,int position,Form form)
        {
            Map = new Map(image, new Size(size, size), new Point(position, position), form);
        }
        public static void CreatePlayer(string PlayerName)
        {
            Player = new Player(PlayerName);
        }
        public static void CreateEnemy()
        {
            Enemy = new Enemy();
        }
    }
}
