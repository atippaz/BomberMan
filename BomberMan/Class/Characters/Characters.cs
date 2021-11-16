using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
    class Characters : CharacterMove
    {
        private PictureBox _Animation = new PictureBox()
        {
            SizeMode = PictureBoxSizeMode.Zoom,
        };
        public PictureBox Animation
        {
            get => _Animation;
            set => _Animation = value;
        }
        public Size Size
        {
            get => _Animation.Size;
            set => _Animation.Size = (value.Width > 0 && value.Height > 0) ? value : new Size(50, 50);
        }
        public Point Location
        {
            get => _Animation.Location;
            set => _Animation.Location = (value.X > 0 && value.Y > 0) ? value : new Point(0, 0);
        }
        public string AnimationDirector
        {
            set
            {
                if (value == "Right")
                {
                    _Animation.Image = PlayerImage.RunRight;
                }
                else if (value == "Left")
                {
                    _Animation.Image = PlayerImage.RunLeft;
                }
                else if (value == "Up")
                {
                    _Animation.Image = PlayerImage.RunUp;
                }
                else if (value == "Down")
                {
                    _Animation.Image = PlayerImage.RunDown;
                }
                else
                {
                    _Animation.Image = PlayerImage.Idle;
                }
                DirectionPlayer = value;
            }
        }
    }
}
