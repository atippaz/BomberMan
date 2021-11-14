using System.IO;
using System.Drawing;

namespace BomberMan
{
    static class PlayerImage
    {
        static private string Paths = "..\\..\\resource\\Character\\Player\\";

        static public Image Idle = Image.FromFile(Path.GetFullPath(Paths + "Player_idle.gif"));
        static public Image RunLeft = Image.FromFile(Path.GetFullPath(Paths + "Player_run_left.gif"));
        static public Image RunRight = Image.FromFile(Path.GetFullPath(Paths + "Player_run_right.gif"));
        static public Image RunDown = Image.FromFile(Path.GetFullPath(Paths + "Player_run_down.gif"));
        static public Image RunUp = Image.FromFile(Path.GetFullPath(Paths + "Player_run_up.gif"));
    }
}
