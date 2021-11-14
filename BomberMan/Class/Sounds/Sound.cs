using System;
using System.IO;

namespace BomberMan {
    enum Music {
        MainTheme,
        GameTheme,
    }

    enum Effect {
        Click,
    }


    public static class BgmPath {
        public static string Path(Enum theme) =>
            $"..\\..\\resource\\Sounds\\Bgm\\{theme.ToString()}.wav";
    }

    public static class FxPatch {
        public static string Path(Enum fx) =>
            $"..\\..\\resource\\Sounds\\Fx\\{fx.ToString()}.wav";
    }
}

