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
        static public Image PlayerState = Image.FromFile(Path.GetFullPath(Paths.PathImage + "PlayerState.png"));
        static public Image BestPlayerState = Image.FromFile(Path.GetFullPath(Paths.PathImage + "BestPlayerState.png"));
        static public Image PlayerWait = Image.FromFile(Path.GetFullPath(Paths.PathImage + "PlayerWait.gif"));
        static public Image PlayerReady = Image.FromFile(Path.GetFullPath(Paths.PathImage + "PlayerReady.gif"));
        static public Image WinState = Image.FromFile(Path.GetFullPath(Paths.PathImage + "WinState.gif"));
        static public Image LoseState = Image.FromFile(Path.GetFullPath(Paths.PathImage + "LoseState.gif"));
        static public Image SpeedBootsState = Image.FromFile(Path.GetFullPath(Paths.PathImage + "SpeedBootsState.png"));
        static public Image IncreaseBombState = Image.FromFile(Path.GetFullPath(Paths.PathImage + "IncreaseBombState.png"));
        static public Image PowerBombState = Image.FromFile(Path.GetFullPath(Paths.PathImage + "PowerBombState.png"));
        static public Image HeartFull = Image.FromFile(Path.GetFullPath(Paths.PathImage + "HeartFull.png"));
        static public string IconGame = Paths.PathImage + "IconGame.ico";
    }
}
