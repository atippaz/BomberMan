using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    class Fires
    {
        private PictureBox fire;
        List<Control> Fire;
        public Fires() 
        {
            Fire = new List<Control>();
        }
        public void Up(Map map,Point bomb,int power ,int TileSize)
        {
             fire = new PictureBox()
            {
                Size = new Size(TileSize, TileSize),
                Location = new Point( bomb.X,bomb.Y - TileSize),
                Image = Images.Fire,
                SizeMode = PictureBoxSizeMode.Zoom,
            };
            Fire.Add(fire);
            map.AddTiles(fire);
        }
        public void Left(Map map, Point bomb, int power, int TileSize)
        {
            fire = new PictureBox()
            {
                Size = new Size(TileSize, TileSize),
                Location = new Point(bomb.X-TileSize, bomb.Y),
                Image = Images.Fire,
                SizeMode = PictureBoxSizeMode.Zoom,
            };
            Fire.Add(fire);
            map.AddTiles(fire);
        }
        public void Down(Map map, Point bomb, int power, int TileSize)
        {
            fire = new PictureBox()
            {
                Size = new Size(TileSize, TileSize),
                Location = new Point(bomb.X, bomb.Y + TileSize),
                Image = Images.Fire,
                SizeMode = PictureBoxSizeMode.Zoom,
            };
            Fire.Add(fire);
            map.AddTiles(fire);
        }
        public void Right(Map map, Point bomb, int power, int TileSize)
        {
            fire = new PictureBox()
            {
                Size = new Size(TileSize, TileSize),
                Location = new Point(bomb.X +TileSize, bomb.Y),
                Image = Images.Fire,
                SizeMode = PictureBoxSizeMode.Zoom,
            };
            Fire.Add(fire);
            map.AddTiles(fire);
        }
        public void DeleteFire()
        {
            Fire.ForEach((fire) => fire.Visible = false);
        }
    }
}
