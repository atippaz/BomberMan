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
        static public Image box = Image.FromFile(Path.GetFullPath(Paths.PathMap+"box.png"));
    }
}
