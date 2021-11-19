using System.IO;
using WMPLib;
using System.Threading;
namespace BomberMan
{
    public static class EffectSound
    {
        static Thread _fx;
        private static WindowsMediaPlayer fx = new WindowsMediaPlayer();

        public static void Click()
        {
            _fx = new Thread(_click);
            _fx.Start();
        }
        static void _click()
        {
            fx.URL = Path.GetFullPath(FxPatch.Path(Effect.Click));
        }
    }
}
