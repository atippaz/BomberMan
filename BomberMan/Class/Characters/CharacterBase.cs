namespace BomberMan
{
    class CharacterBase
    {
        #region Fields
        private int _HP;
        private int _Speed;
        private int _Mana;
        private int _MaxHP;
        private int _AtteckPower = 1;
        private int _MaxMana = 3;
        private int _MaxSpeed=10;
        private string _Name;
        #endregion
        #region Properties
        public string Name
        {
            get => _Name;
            set => _Name = (string.IsNullOrEmpty(_Name)) ? "Character" : value;
        }
        protected int MaxHP
        {
            get => _MaxHP;
            set => _MaxHP = (value > 0) ? value : 3;
        }
        protected int MaxMana
        {
            get => _MaxMana;
            set => _MaxMana = (value > 0) ? value : 1;
        }
        protected int MaxSpeed
        {
            get => _MaxSpeed;
            set => _MaxSpeed = (value > 0) ? value : 10;
        }
        public int HP
        {
            get => _HP;
            set => _HP = (value >= 0 && value <= MaxHP) ? value : 1;
        }
        public int Mana
        {
            get => _Mana;
            set => _Mana = (value >= 0 && value <= MaxMana) ? value : 1;
        }
        public int Speed
        {
            get => _Speed;
            set => _Speed = (value >= 0 && value <= MaxSpeed) ? value : 10;
        }
        public int Power
        {
            get => _AtteckPower;
            set => _AtteckPower = (value >= 0) ? value : 1;
        }
        #endregion
    }
}

