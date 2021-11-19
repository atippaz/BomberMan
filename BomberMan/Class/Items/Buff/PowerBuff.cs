using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    class PowerBuff : Items
    {
        public PowerBuff(Point Location) : base("PowerBuff") 
        {
            ItemImage = new PictureBox()
            {
                Location = Location,
                Size = Storages.TileSize,
                Image = MapImage.PowerBomb,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            Storages.Map.AddTiles(ItemImage);
            ItemImage.BringToFront();
            Storages.Player.Animation.BringToFront();
            Storages.ItemImage.Add(ItemImage);
        }
        public override void Effect()
        {
            Storages.Player.Power += 1;
        }
    }
}
