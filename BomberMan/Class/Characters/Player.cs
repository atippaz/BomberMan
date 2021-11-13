using System.Drawing;
namespace BomberMan
{
    class Player : Characters
    {
        public Player(string sName, int nHp, Point position, Size size, Image image) : base(sName, nHp, position, size, image) { }
        public Player(string name) : base(name) { System.Console.WriteLine($"{name}"); }

        #region Methods
        public void AttackEnemy(Enemy player)
        {
            System.Console.WriteLine(player.HP);
        }
        public override void Move(string directions)
        {
            if (directions == "Left")
            {
                this.Character.Left -= 20;
            }
            else if (directions == "Rigth")
            {
                this.Character.Left += 20;
            }
            else if (directions == "Up")
            {
                this.Character.Top -= 20;
            }
            else if (directions == "Down")
            {
                this.Character.Top += 20;
            }

        }
        #endregion
    }
}
