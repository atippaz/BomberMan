namespace BomberMan.Class.Characters
{
    abstract class Characters
    {
        #region Fields
        private int _nHP;
        private int _nWidth;
        private int _nHeight;
        private int _nPositionX;
        private int _nPositionY;
        readonly private int _nAttack;
        readonly private string _sName;
        #endregion
        #region Properties
        public int HP { get => _nHP; }
        public string Name { get => _sName; }
        public int Attack { get => _nAttack; }
        public int Width { get => _nWidth; set => _nWidth = (value > 0) ? value : 0; }
        public int Height { get => _nHeight; set => _nHeight = (value > 0) ? value : 0; }
        public int PositionY { get => _nPositionY; set => _nPositionY = (value > 0) ? value :0; }
        public int PositionX { get => _nPositionX; set => _nPositionX = (value > 0) ? value : 0; }
        #endregion
        #region Constructors
        public Characters()
        {
            this._sName = "Player";
            this._nHP = 3;
            this.PositionY = this.PositionX = this.Height = this.Width = 0;
        }
        public Characters(string sName, int nHp, int nPositionX, int nPositionY, int nWidth, int nHeight)
        {
            this._sName = sName;
            this._nHP = (nHp > 0) ? nHp : 3;
            this.PositionY = nPositionX;
            this.PositionX = nPositionY;
            this.Height = nWidth;
            this.Width = nHeight;
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
