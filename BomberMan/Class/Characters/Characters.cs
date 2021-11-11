namespace BomberMan.Class.Characters
{
    abstract class Characters
    {
        #region Fields
        readonly private string _sName;
        private int _nHP;
        readonly private int _nAttack;
        #endregion
        #region Properties
        public string Name { get => _sName; }
        public int HP { get => _nHP; }
        public int Attack { get => _nAttack; }
        #endregion
        #region Constructors
        public Characters()
        {
            _sName = "Player";
            _nHP = 3;
        }
        public Characters(string name, int hp)
        {
            _sName = name;
            _nHP = (hp > 0) ? hp : 3;
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
