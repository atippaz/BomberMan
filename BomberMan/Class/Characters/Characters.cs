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
        public int Attack { get => _nAttack; }
        public PictureBox Character { get; set; }
        #endregion
        #region Constructors
        public Characters()
        {
            Character.Name = "Player001";
            this._nHP = 3;
        }
        public Characters(string sName, int nHp, int nPositionX, int nPositionY, int nWidth, int nHeight,string image)
        {
          
            this._nHP = (nHp > 0) ? nHp : 3;
            
        }
        #endregion
        #region Methods
        abstract public void Move();
        internal void SetHp(int value)
        {
            this._nHP += value;
        }
        #endregion
    }
}
