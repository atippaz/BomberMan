using System;
using System.Media;

namespace BomberMan {
    static class BackGroundMusic {
        #region Fields
        private static SoundPlayer Bgm;
        private static string _Path;
        #endregion

        #region Methods
        public static void Play() {
            Bgm = new SoundPlayer(_Path);
            Bgm.PlayLooping();
        }

        public static void Set(Enum theme) {
            _Path =  BgmPath.Path(theme);
        }

        public static void Stop() {
            Bgm = new SoundPlayer();
            Bgm.Stop();
        }
        #endregion
    }
}
