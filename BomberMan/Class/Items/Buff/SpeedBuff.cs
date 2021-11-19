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
            System.Console.WriteLine($"{Storages.Player.Speed}");
            if(Storages.Player.Speed == 2)
            {
                Storages.Player.Speed = 5;
            }
            else if(Storages.Player.Speed == 5)
            {
                Storages.Player.Speed = 10;
            }
            else if(Storages.Player.Speed == 10)
            {
                Storages.Player.Speed = 25;
            }else if(Storages.Player.Speed == 25)
            {
                Storages.Player.Speed = 50;
            }
        }
    }
}
