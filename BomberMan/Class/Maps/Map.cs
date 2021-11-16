using System.Drawing;
using System.Windows.Forms;
namespace BomberMan
{
    class Map
    {
        private PictureBox _pbMap;
        public PictureBox MapProperties
        {
            get => _pbMap;
        }
        public Image MapImage
        {
            get => _pbMap.Image;
            set => _pbMap.Image = value;
        }

        public Map(Image mapImage, Size size,Point position,Form form)
        {
            this._pbMap = new PictureBox()
            {
                Name = "Map",
                Size = size,
                Location = position,
                BackgroundImage = mapImage,
                BackgroundImageLayout = ImageLayout.Tile,
            };
            form.Controls.Add(this._pbMap);
        }
        public void Add(Form form)
        {
            form.Controls.Add(_pbMap);
        }
        public void AddTiles(PictureBox elements)
        {
            this._pbMap.Controls.Add(elements);
            elements.BackColor = Color.Transparent;
        }
    }
}
