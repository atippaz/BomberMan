using System.Drawing;
using System.Windows.Forms;
namespace BomberMan
{
    abstract class Characters
    {
        #region Fields
        private int _nHP;
        private PictureBox _pbCharacter;
        readonly private int _nAttack;
        #endregion
        #region Properties
        public int HP { get => _nHP; }
        public PictureBox Character { get; }
        public Image Image
        {
            get => this.Character.Image;
            set => this.Character.Image = (value.GetType() == Image.GetType()) ? value : PlayerImage.Idle;
        }
        public Point Location
        {
            get => this.Character.Location;
            set => Character.Location = new Point((value.X > 0) ? value.X : 0, (value.Y > 0) ? value.Y : 0);
        }
        #endregion
        #region Constructors
        public Characters()
        {
            this._nHP = 3;
            Character = new PictureBox()
            {
                Name = "Player001",
                Image = PlayerImage.Idle,
                Location = new Point(0, 0),
                Size = new Size(50, 50),
            };
        }
        public Characters(string sName, int nHp, Point Position, Size Size, Image Image)
        {
            this._nHP = (nHp > 0) ? nHp : 3;
            Character = new PictureBox()
            {
                Name = $"{sName}",
                Image = Image,
                Location = Position,
                Size = Size,
            };
        }
        public Characters(string sName)
        {
            this._nHP = 3;
            Character = new PictureBox()
            {
                Name = $"{sName}",
                Image = PlayerImage.Idle,
                Location = new Point(0, 0),
                Size = new Size(50, 50),
            };
        }
        #endregion
        #region Methods
        abstract public void Move(string directions);
        internal void SetHp(int value)
        {
            this._nHP += value;
        }
        #endregion
    }
}

