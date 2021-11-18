using System;
using System.Drawing;

namespace BomberMan
{
    static class RandomItems
    {
        static public void Randomitem()
        {
            /*rate drop 
             * Dont Drop any Buff 80%
             * Drop any Buff 20%
             * Speed buff = 50%
             * Heal Buff = 20%
             * Power Buff = 30%
             */
            Random randomBuff = new Random();
            Storages.LocationItemRandom.ForEach((location) =>
            {
                int randomvalue = randomBuff.Next(1, 10);
                if (randomvalue > 3)
                {
                    randomvalue = randomBuff.Next(1, 10);
                    Items buff;
                    if (randomvalue > 8)
                    {
                        buff = new HealBuff(location);
                    }
                    else if (randomvalue > 3)
                    {
                        buff = new SpeedBuff(location);
                    }
                    else
                    {
                        buff = new PowerBuff(location);
                    }
                    Storages.ItemHasDrop = true;
                    Storages.Items.Add(buff);
                }
            });
            Storages.LocationItemRandom.Clear();
        }
    }
}
