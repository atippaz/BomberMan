using System.Drawing;
using System.IO;

namespace BomberMan {
    static class Images {
        static public Image BtnStartCharacterAnimate = Image.FromFile(Path.GetFullPath(Paths.PathImage + "BtnStartCharacterAnimate.gif"));
        static public Image BtnExitCharaterAnimate = Image.FromFile(Path.GetFullPath(Paths.PathImage + "BtnExitCharacterAnimate.gif"));
        static public Image Blackboard = Image.FromFile(Path.GetFullPath(Paths.PathImage + "Blackboard.jpg"));
        static public Image LogoGame = Image.FromFile(Path.GetFullPath(Paths.PathImage + "LogoGame.gif"));
        static public Image Library = Image.FromFile(Path.GetFullPath(Paths.PathImage + "Library.gif"));
        static public Image Library2 = Image.FromFile(Path.GetFullPath(Paths.PathImage + "Library2.gif"));
        static public Image Fire = Image.FromFile(Path.GetFullPath(Paths.PathImage + "Fire.gif"));
        static public Image Fire2 = Image.FromFile(Path.GetFullPath(Paths.PathImage + "Fire2.gif"));
        static public string IconGame = Paths.PathImage + "IconGame.ico";
    }
}
