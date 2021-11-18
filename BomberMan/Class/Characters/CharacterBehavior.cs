namespace BomberMan
{
    class CharacterBehavior : CharacterBase
    {
        Bomb bomb;
        public bool CanBomb = true;
        public bool CanHitDamage = true;
        public void Planbomb()
        {
            bomb = new Bomb(Storages.IntegerTileSize);
        }
    }
}
