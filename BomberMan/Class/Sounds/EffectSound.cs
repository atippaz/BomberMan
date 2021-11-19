using System.IO;
using WMPLib;
using System.Windows.Forms;
using System.Threading;
namespace BomberMan
{
    public static class EffectSound
    {
        private static WindowsMediaPlayer fx1 = new WindowsMediaPlayer();
        private static WindowsMediaPlayer fx2 = new WindowsMediaPlayer();

        public static void Click()
        {
            fx1.URL = Path.GetFullPath(FxPatch.Path(Effect.Click));
            fx1.controls.play();
        }

        public static void Boom() 
        {
            fx2.URL = Path.GetFullPath(FxPatch.Path(Effect.Boom));
            fx2.controls.play();
        }
    }
}
