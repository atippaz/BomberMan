using System;
using System.Drawing;

namespace BomberMan
{
    static class RandomItems
    {
        static public void Randomitem()
        {
            /*rate drop 
             * Dont Drop any Buff 40%
             * Drop any Buff 60%
                * Speed buff = 30%
                * Heal Buff = 20%
                * Power Buff = 30%
                * number bomb Buff = 20%
             */
            Random randomBuff = new Random();
            Storages.LocationItemRandom.ForEach((location) =>
            {
                int randomvalue = randomBuff.Next(1, 10);
                if (randomvalue > 4)
                {
                    randomvalue = randomBuff.Next(1, 10);
                    Items buff;
                    if (randomvalue > 8)
                    {
                        buff = new HealBuff(location);
                    }
                    else if (randomvalue >= 4)
                    {
                        buff = new SpeedBuff(location);
                    }
                    else if(randomvalue > 2)
                    {
                        buff = new PowerBuff(location);
                    }
                    else
                    {
                        buff = new BombNumber(location);
                    }
                    Storages.ItemHasDrop = true;
                    Storages.Items.Add(buff);
                }
            });
            Storages.LocationItemRandom.Clear();
        }
    }
}
