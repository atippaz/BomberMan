﻿using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    class HealBuff : Items
    {
        public HealBuff(Point Location) : base("PowerBuff") 
        {
            ItemImage = new PictureBox()
            {
                Location = Location,
                Size = Storages.TileSize,
                Image = MapImage.Heal,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            Storages.Map.AddTiles(ItemImage);
            ItemImage.BringToFront();
            Storages.Player.Animation.BringToFront();
            Storages.ItemImage.Add(ItemImage);
        }
        public override void Effect()
        {
            Storages.Player.HP += 1;
        }
    }

}
