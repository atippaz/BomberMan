namespace BomberMan.Class.Items
{
    class Items
    {
        #region Fields
        private string _sName;
        #endregion
        #region Properties
        public string Name { get => _sName; }
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
        public void SetName(string name)
        {
            _sName = name;
        }
        #endregion
    }
}
