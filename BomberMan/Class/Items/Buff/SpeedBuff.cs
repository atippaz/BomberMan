using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    class SpeedBuff:Items
    {
        public SpeedBuff(Point Location, int Size) :base("SpeedBuff")
        {
            ItemImage = new PictureBox()
            {
                Location = Location,
                Size = new Size(Size, Size),
                Image = MapImage.NoHeart,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            Storages.Map.AddTiles(ItemImage);
            ItemImage.BringToFront();
            Storages.Player.Animation.BringToFront();
            Storages.Items.Add(ItemImage);
        }
        public override void Effect(Player player)
        {
            player.Speed += 1;
        }
    }
}
