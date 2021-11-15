namespace BomberMan
{
    class Enemy : Characters
    {
        #region Methods
        public void AttackEnemy(Player player)
        {
            System.Console.WriteLine(player.HP);
        }
        public override void Move(string directions)
        {

        }
        #endregion
    }
}
