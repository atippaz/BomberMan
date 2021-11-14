using System.Drawing;
using System.IO;

namespace BomberMan {
    static class AccessoryImags {
        static private string Paths = "..\\..\\resource\\Images\\Accessory\\";   
        
        static public Image Blackboard = Image.FromFile(Path.GetFullPath(Paths + "Blackboard.jpg"));
        static public Image LogoGame = Image.FromFile(Path.GetFullPath(Paths + "LogoGame.gif"));
        static public Image Library = Image.FromFile(Path.GetFullPath(Paths + "Library.gif"));
        static public Image Library2 = Image.FromFile(Path.GetFullPath(Paths + "Library2.gif"));
        static public Image Fire = Image.FromFile(Path.GetFullPath(Paths + "Fire.gif"));
        static public Image Fire2 = Image.FromFile(Path.GetFullPath(Paths + "Fire2.gif"));

        static public string IconGame = Paths + "IconGame.ico";
    }
}
