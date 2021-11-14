using System.Drawing;
using System.IO;

namespace BomberMan {
    static class DecorateImage {    
        static public Image Blackboard = Image.FromFile(Path.GetFullPath(Paths.PathDecorate + "Blackboard.jpg"));
        static public Image LogoGame = Image.FromFile(Path.GetFullPath(Paths.PathDecorate + "logo.gif"));
    }
}
