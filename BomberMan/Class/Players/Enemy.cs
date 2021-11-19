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
            Size = new Size(Storages.IntegerTileSize, Storages.IntegerTileSize);
            Location = new Point(Storages.IntegerSize- (Storages.IntegerTileSize*2), Storages.IntegerSize - (Storages.IntegerTileSize * 2));
            MaxHP = 3;
            MaxMana = 3;
            MaxSpeed = Storages.IntegerTileSize;
            Name = "name";
            Animation.Tag = "Enemy";
            Speed = 10;
            while (Storages.IntegerSize%Speed!=0)
            {
                Speed++;
            }
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
