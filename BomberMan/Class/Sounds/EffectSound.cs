using System.IO;
using WMPLib;

namespace BomberMan
{
    public static class EffectSound
    {
        private static WindowsMediaPlayer fx = new WindowsMediaPlayer();

        public static void Click()
        {
            fx.URL = Path.GetFullPath(FxPatch.Path(Effect.Click));
        }
    }
}
