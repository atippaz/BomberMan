using System.Windows.Forms;
using System.Drawing;
namespace BomberMan
{
    class Bombs
    {
        private int damage;
        PictureBox[] Bomb;
        public Bombs()
        {
            damage = 1;
        }

        public PictureBox[] ActiveBomb()
        {
           
            return Bomb;
        }
    }
}
