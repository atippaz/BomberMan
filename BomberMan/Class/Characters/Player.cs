namespace BomberMan
{
    class Player : Characters
    {
        public Player(string sName, int nHp, int x, int y, int nWidth, int nHeight, string image) : base(sName, nHp, x, y, nWidth, nHeight, image) {}
        #region Methods
        public void AttackEnemy(Enemys player)
        {
            System.Console.WriteLine(player.HP);
        }
        public override void Move()
        {

        }
        #endregion
    }
}
