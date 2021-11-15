using System;

namespace BomberMan {
    #region Enum storag sound files
    enum Music {
        MainTheme,
        GameTheme,
    }

    enum Effect {
        Click,
    }
    #endregion

    public static class BgmPath {
        public static string Path(Enum theme) =>$"{Paths.PathBgm}{theme.ToString()}.wav";
    }
    public static class FxPatch {
        public static string Path(Enum fx) =>$"{Paths.PathFx}{fx.ToString()}.wav";
    }
}

