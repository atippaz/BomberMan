using System.Drawing;
using System.Windows.Forms;
namespace BomberMan
{
    class Player : Characters
    {
        public Player(PictureBox BackGround)
        {
            Animation.Image = PlayerImage.Idle;
            Size = new Size(50, 50);
            Location = new Point(0, 0);
            MaxHP = 3;
            MaxMana = 3;
            MaxSpeed = 50;
            Name = "name";
            BackGround.Controls.Add(Animation);
            Animation.BackColor = Color.Transparent;
        }
        public Player(string Name, PictureBox BackGround)
        {
            Animation.Image = PlayerImage.Idle;
            Size = new Size(50, 50);
            Location = new Point(50, 50);
            MaxHP = 3;
            MaxMana = 3;
            MaxSpeed = 50;
            this.Name = Name;
            BackGround.Controls.Add(Animation);
            Animation.BackColor = Color.Transparent;
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
        public override string ToString()
        {
            return $"{base.Name}: {base.Power} : {base.Speed} : {base.HP}";
        }
        #endregion
    }
}
