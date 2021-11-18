using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberMan
{
    static class EnemyImage
    {
        static public Image Idle = Image.FromFile(Path.GetFullPath(Paths.PathEnemy + "Enemy_idle.gif"));
        static public Image RunLeft = Image.FromFile(Path.GetFullPath(Paths.PathEnemy + "Enemy_run_left.gif"));
        static public Image RunRight = Image.FromFile(Path.GetFullPath(Paths.PathEnemy + "Enemy_run_right.gif"));
        static public Image RunDown = Image.FromFile(Path.GetFullPath(Paths.PathEnemy + "Enemy_run_down.gif"));
        static public Image RunUp = Image.FromFile(Path.GetFullPath(Paths.PathEnemy + "Enemy_run_up.gif"));
    }
}
