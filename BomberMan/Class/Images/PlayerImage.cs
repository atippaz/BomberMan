using System.IO;
using System.Drawing;

namespace BomberMan
{
    static class PlayerImage
    {
        static private string PathPlayer = "..\\..\\resource\\Character\\Player\\";

        static public Image Idle = Image.FromFile(Path.GetFullPath(PathPlayer + "student_idle.gif"));
        static public Image RunLeft = Image.FromFile(Path.GetFullPath(PathPlayer + "student_run_left.gif"));
        static public Image RunRight = Image.FromFile(Path.GetFullPath(PathPlayer + "student_run_right.gif"));
        static public Image RunDown = Image.FromFile(Path.GetFullPath(PathPlayer + "student_run_down.gif"));
        static public Image RunUp = Image.FromFile(Path.GetFullPath(PathPlayer + "student_run_up.gif"));
    }
}
