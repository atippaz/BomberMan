using System.Drawing;
using System.Windows.Forms;

namespace BomberMan
{
     class Items
    {
        #region Fields
        private string _sName;
        protected PictureBox ItemImage;
        #endregion
        #region Properties
        public string Name { get => _sName; }
        public Point Location { get => ItemImage.Location; }
        public PictureBox Image { get => ItemImage; }
        #endregion
        #region Constructors
        public Items()
        {
            _sName = "Items";
        }
        public Items(string name)
        {
            _sName = name;
        }
        #endregion
        #region Methods
        virtual public void Effect(Player player) { }
        #endregion
    }
}
