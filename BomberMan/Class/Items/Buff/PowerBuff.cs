using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    class PowerBuff : Items
    {
        public PowerBuff(Point Location,int Size) : base("PowerBuff") 
        {
            ItemImage = new PictureBox()
            {
                Location = Location,
                Size = new Size(Size, Size),
                Image = MapImage.Wall,
                SizeMode = PictureBoxSizeMode.Zoom
            };
            Storages.Map.AddTiles(ItemImage);
            ItemImage.BringToFront();
            Storages.Player.Animation.BringToFront();
            Storages.ItemImage.Add(ItemImage);
        }
        public override void Effect(Player player)
        {
            player.Power += 1;
        }
    }
}
