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
            MaxMana = 1;
            MaxSpeed = 10;
            Name = "name";
            BackGround.Controls.Add(Animation);
            Animation.BackColor = Color.Transparent;
        }
        public Player(string Name, PictureBox BackGround)
        {
            Animation.Image = PlayerImage.Idle;
            Size = new Size(50, 50);
            Location = new Point(0, 0);
            MaxHP = 3;
            MaxMana = 1;
            MaxSpeed = 10;
            this.Name = Name;
            BackGround.Controls.Add(Animation);
            Animation.BackColor = Color.Transparent;
        }
        #region Methods
        public override void Move(string directions,int step)
        {
            if (directions == "Left")
            {
                System.Console.WriteLine(step);
                while(step != 0)
                {
                    System.Console.WriteLine(step);
                    System.Console.WriteLine(this.Speed);

                    this.Animation.Left -= this.Speed;
                    step -= this.Speed;
                }
                
            }
            else if (directions == "Right")
            {
                this.Animation.Left += 20;
            }
            else if (directions == "Up")
            {
                this.Animation.Top -= 20;
            }
            else if (directions == "Down")
            {
                this.Animation.Top += 20;
            }
        }
        #endregion
    }
}
