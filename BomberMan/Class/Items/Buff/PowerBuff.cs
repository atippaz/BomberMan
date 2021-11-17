using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberMan
{
    class PowerBuff : Items
    {
        public PowerBuff() : base("PowerBuff") { }
        public override void Effect(Player player)
        {
            player.Power += 1;
        }
    }
}
