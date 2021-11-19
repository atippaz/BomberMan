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
        static public Image Wall = Image.FromFile(Path.GetFullPath(Paths.PathMap + "Wall.png"));
        static public Image Bomb = Image.FromFile(Path.GetFullPath(Paths.PathMap + "Bomb.gif"));
        static public Image BookBox = Image.FromFile(Path.GetFullPath(Paths.PathMap + "BookBox.png"));
        static public Image TileBlue = Image.FromFile(Path.Combine(Paths.PathMap , "TileBlue.png"));
        static public Image SpeedBoots = Image.FromFile(Path.GetFullPath(Paths.PathMap + "SpeedBoots.gif"));
        static public Image PowerBomb = Image.FromFile(Path.GetFullPath(Paths.PathMap + "PowerBomb.gif"));
        static public Image IncreaseBomb = Image.FromFile(Path.GetFullPath(Paths.PathMap + "IncreaseBomb.gif"));
        static public Image Heal = Image.FromFile(Path.GetFullPath(Paths.PathMap + "Heal.gif"));
        //static public Image Fire = Image.FromFile(Path.GetFullPath(Paths.PathMap + "Fire.png"));
    }
}
