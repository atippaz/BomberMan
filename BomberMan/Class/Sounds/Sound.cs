using System;

namespace BomberMan {
    #region Enum storag audio files
    enum Music {
        MainTheme,
        GameTheme,
        OverTheme
    }

    enum Effect {
        Click,
        Boom
    }
    #endregion

    public static class BgmPath {
        public static string Path(Enum theme) =>$"{Paths.PathBgm}{theme.ToString()}.wav";
    }
    public static class FxPatch {
        public static string Path(Enum fx) =>$"{Paths.PathFx}{fx.ToString()}.wav";
    }
}

