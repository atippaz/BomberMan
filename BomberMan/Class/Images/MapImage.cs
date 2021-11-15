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


    }
}
