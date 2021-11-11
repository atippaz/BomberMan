namespace BomberMan.Class.Characters
{
    class Enemys : Characters
    {
        #region Methods
        public void AttackEnemy(Player player)
        {
            System.Console.WriteLine(player.HP);
        }
        public override void Move()
        {

        }
        #endregion
    }
}
