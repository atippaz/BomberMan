using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BomberMan
{
    static class Controllers
    {
        static public void walk(string Directions, bool walkAble, int steps, bool UseBomb,Characters Player)
        {

            Point location = new Point(0, 0);
            //hitbox.BackColor = Color.Red;
            #region check
            if (Directions == "Right")
            {
                location = new Point(Player.Location.X + Storages.IntegerTileSize, Player.Location.Y);
            }
            else if (Directions == "Left")
            {
                location = new Point(Player.Location.X - Storages.IntegerTileSize, Player.Location.Y);
            }
            else if (Directions == "Up")
            {
                location = new Point(Player.Location.X, Player.Location.Y - Storages.IntegerTileSize);
            }
            else if (Directions == "Down")
            {
                location = new Point(Player.Location.X, Player.Location.Y + Storages.IntegerTileSize);
            }
            if (walkAble)
            {
                Storages.Tiles.ForEach((boxs) =>
                {
                    if (location == boxs.Location)
                    {
                        walkAble = false;
                        Player.WalkFinish = true;
                    }
                });
            }

            #endregion

            if (walkAble)
            {
                while(steps > 0)
                {
                    if (steps > 0)
                    {
                        Player.Move(Directions);
                        steps -= Player.Speed;
                    }
                    else
                    {
                        Player.WalkFinish = true;
                        walkAble = false;
                        UseBomb = true;
                    }
                }
                
            }
            if (Player.DirectionPlayer != Directions)
            {
                Player.AnimationDirector = Directions;
            }

        }
    }
}
