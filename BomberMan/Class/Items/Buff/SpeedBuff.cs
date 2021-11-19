using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    class SpeedBuff:Items
    {
        public SpeedBuff(Point Location) :base("SpeedBuff")
        {
            ItemImage = new PictureBox()
            {
                Location = Location,
                Size = Storages.TileSize,
                Image = MapImage.NoHeart,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            Storages.Map.AddTiles(ItemImage);
            ItemImage.BringToFront();
            Storages.Player.Animation.BringToFront();
            Storages.ItemImage.Add(ItemImage);
        }
        public override void Effect()
        {
            Storages.Player.Speed +=1;
            while (Storages.IntegerTileSize % Storages.Player.Speed !=0)
            {
                Storages.Player.Speed++;
            }
        }
    }
}
