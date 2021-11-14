using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using WMPLib;
using System.Threading;
using System;

namespace BomberMan
{
    public static class EffectSound
    {
        private static WindowsMediaPlayer fx = new WindowsMediaPlayer();
        private static string _Path;

        public static void Click()
        {
            fx.URL = Path.GetFullPath(FxPatch.Path(Effect.Click));
        }

    }
}
