using System.Drawing;

namespace BomberMan
{
    class CharacterBehavior : CharacterBase
    {
        Bomb bomb;
        public bool CanBomb = true;
        public bool CanHitDamage = true;
        public void Planbomb(Point location,Characters player)
        {
            bomb = new Bomb(location, player);
        }
    }
}
