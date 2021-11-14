namespace BomberMan
{
    class CharacterBase
    {
        #region Fields
        private int _HP;
        private int _Speed;
        private int _Mana;
        private int _MaxHP;
        private int _MaxMana;
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
            set => _MaxMana = (value >= 0 && value <= MaxMana) ? value : 1;
        }
        public int Speed
        {
            get => _Speed;
            set => _MaxSpeed = (value >= 0 && value <= MaxSpeed) ? value : 10;
        }
        #endregion
    }
}

