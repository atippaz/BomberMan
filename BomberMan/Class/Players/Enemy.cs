using System;
using System.Drawing;
using System.Windows.Forms;
namespace BomberMan
{
    class Enemy : Characters
    {
        public Enemy()
        {
            Animation.Image = EnemyImage.Idle;
            Size = new Size(50, 50);
            Location = new Point(Storages.IntegerSize-100, Storages.IntegerSize - 100);
            MaxHP = 3;
            MaxMana = 3;
            MaxSpeed = 50;
            Name = "name";
            Animation.Tag = "Enemy";
            Speed = 5;
            HP = 1;
            Storages.Map.MapProperties.Controls.Add(Animation);
            Animation.BackColor = Color.Transparent;
        }
        #region Methods
        public void AttackEnemy(Player player)
        {
          
        }
        public override void Move(string directions)
        {
            if (directions == "Left")
            {
                this.Animation.Left -= this.Speed;
            }
            else if (directions == "Right")
            {
                this.Animation.Left += this.Speed;
            }
            else if (directions == "Up")
            {
                this.Animation.Top -= this.Speed;
            }
            else if (directions == "Down")
            {
                this.Animation.Top += this.Speed;
            }
        }
        #endregion
    }
}
