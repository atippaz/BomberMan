namespace BomberMan
{
    class CharacterBase
    {
        #region Fields
        private int _HP =1;
        private int _Speed =5;
        private int _Mana=1;
        private int _MaxHP =3;
        private int _MaxAtk = 3 ;
        private int _AtteckPower = 1;
        private int _MaxMana = 3;
        private int _MaxSpeed = 50;
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
            set => _MaxSpeed = (value > 0) ? value : 1;
        }
        protected int MaxAtk
        {
            get => _MaxAtk;
            set => _MaxAtk = (value > 0) ? value : 1;
        }
        public int HP
        {
            get => _HP;
            set
            {
                if (value <= MaxHP)
                {
                    if (value > 0)
                    {
                        _HP = value;
                    }
                    else
                    {
                        _HP = 1;
                    }
                }
                else
                {
                    _HP = MaxHP;
                }
            }
        }
        public int Mana
        {
            get => _Mana;
            set
            {
                if (value <= MaxMana)
                {
                    if (value >= 0)
                    {
                        _Mana = value;
                    }
                    else
                    {
                        _Mana = 0;
                    }
                }
                else
                {
                    _Mana = MaxMana;
                }
            }
        }
        public int Speed
        {
            get => _Speed;
            set
            {
                if (value <= MaxSpeed)
                {
                    if (value > 0)
                    {
                        _Speed = value;
                    }
                    else
                    {
                        _Speed = 1;
                    }
                }
                else
                {
                    _Speed = MaxSpeed;
                }
            }
        }
        public int Power
        {
            get => _AtteckPower;
            set 
            {
                if (value <= MaxAtk)
                {
                    if (value > 0)
                    {
                        _AtteckPower = value;
                    }
                    else
                    {
                        _AtteckPower = 1;
                    }
                }
                else
                {
                    _AtteckPower = MaxAtk;
                }
            }
        }
        #endregion
    }
}

