using System.Drawing;
using System.Windows.Forms;
namespace BomberMan
{
    class Player : Characters
    {
        
        public Player()
        {
            Animation.Image = PlayerImage.Idle;
            Size = new Size(Storages.IntegerTileSize, Storages.IntegerTileSize);
            Location = new Point(Storages.IntegerTileSize, Storages.IntegerTileSize);
            MaxHP = 3;
            MaxMana = 3;
            MaxSpeed = 50;
            Name = "Player";
            Storages.Map.MapProperties.Controls.Add(Animation);
            Animation.BackColor = Color.Transparent;
            Animation.Tag = "Player";
        }
        #region Methods
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
