using System.Drawing;
using System.Windows.Forms;
namespace BomberMan
{
    class Enemy : Characters
    {
        public Enemy()
        {
            Animation.Image = PlayerImage.Idle;
            Size = new Size(50, 50);
            Location = new Point(100, 50);
            MaxHP = 3;
            MaxMana = 3;
            MaxSpeed = 50;
            Name = "name";
            Storages.Map.MapProperties.Controls.Add(Animation);
            Animation.BackColor = Color.Transparent;
        }
        #region Methods
        public void AttackEnemy(Player player)
        {
          
        }
        public override void Move(string directions)
        {

        }
        #endregion
    }
}
