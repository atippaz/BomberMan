using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using WMPLib;
namespace BomberMan
{
    public static class SoundEffect
    {

        private static SoundPlayer BG;
        private static WindowsMediaPlayer Effect = new WindowsMediaPlayer();

        public static void BGM_Play()
        {
            BG = new SoundPlayer(Properties.Resources.BG_update);
            BG.PlayLooping();
        }
        public static void BGM_Play1()
        {
            BG = new SoundPlayer(Properties.Resources.SongLogin);
            BG.PlayLooping();
        }
        public static void BGM_Stop()
        {
            BG.Stop();
        }
        public static void Effects()
        { 
            Effect.URL = Path.GetFullPath("..\\..\\resource\\MusicEffect\\GameEnter.wav");
        }

    }
}
