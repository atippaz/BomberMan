using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace BomberMan
{
    static class MapImage
    {
        static public Image Box = Image.FromFile(Path.GetFullPath(Paths.PathMap+"Box.png"));
        static public Image Wall = Image.FromFile(Path.GetFullPath(Paths.PathMap + "Wall.png"));
        static public Image Bomb = Image.FromFile(Path.GetFullPath(Paths.PathMap + "Bomb.png"));
        static public Image BookBox = Image.FromFile(Path.GetFullPath(Paths.PathMap + "BookBox.png"));
        static public Image TileBlue = Image.FromFile(Path.Combine(Paths.PathMap , "TileBlue.png"));
        static public Image Heart = Image.FromFile(Path.GetFullPath(Paths.PathMap + "Heart.png"));
        static public Image NoHeart = Image.FromFile(Path.GetFullPath(Paths.PathMap + "NoHeart.png"));
        //static public Image Fire = Image.FromFile(Path.GetFullPath(Paths.PathMap + "Fire.png"));
    }
}
