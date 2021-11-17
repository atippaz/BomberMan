using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberMan
{
    class SpeedBuff:Items
    {
        public SpeedBuff():base("SpeedBuff"){}
        public override void Effect(Player player)
        {
            player.Speed += 1;
        }
    }
}
