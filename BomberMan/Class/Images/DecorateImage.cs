using System.Drawing;
using System.IO;

namespace BomberMan {
    static class DecorateImage {
        static private string PathDecorate = "..\\..\\resource\\DecorateImage\\";      
        static public Image Blackboard = Image.FromFile(Path.GetFullPath(PathDecorate + "Blackboard.jpg"));
        static public Image LogoGame = Image.FromFile(Path.GetFullPath(PathDecorate + "logo.gif"));
    }
}
