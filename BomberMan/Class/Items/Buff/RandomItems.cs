using System;

namespace BomberMan
{
    static class RandomItems
    {
        static public void Randomitem()
        {
            /*rate drop 
             * Speed buff = 33.33%
             * Heal Buff = 33.33%
             * Power Buff = 33.33%
             * Dont drop any Buff   
             */
            Random randomBuff = new Random();
            int randomvalue = randomBuff.Next(0, 10);
            /* for (int i = 0; i < 50; i++)
             {
                 int randomvalue = randomBuff.Next(0, 10);*/
            if (randomvalue > 8)
            {
                randomvalue = randomBuff.Next(0, 10);
                Console.WriteLine($"{randomvalue}");
                if(randomvalue > 8)
                {
                    HealBuff buff = new HealBuff(new System.Drawing.Point(100,100),50);
                }
                else if(randomvalue > 4)
                {
                    SpeedBuff buff = new SpeedBuff(new System.Drawing.Point(100, 100), 50);
                }
                else
                {
                    PowerBuff buff = new PowerBuff(new System.Drawing.Point(100, 100), 50);
                }
            }
            /*else
            {
                dondrop++;
            }*/
            /*}
            Console.WriteLine($"drop : {drop} \nnot drop{dondrop}");*/

        }
    }
}
