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

        public Map(Image mapImage, Size size)
        {
            System.Console.WriteLine($"{mapImage}");
            this._pbMap = new PictureBox()
            {
                Name = "Map",
                Size = size,
                Location = new Point(100, 100),
                Image = mapImage,
                SizeMode = PictureBoxSizeMode.Zoom,
            };

        }
        public void Add(Form form)
        {
            form.Controls.Add(_pbMap);
        }
        public void AddPicture(PictureBox elements)
        {
            this._pbMap.Controls.Add(elements);
        }
    }
}
