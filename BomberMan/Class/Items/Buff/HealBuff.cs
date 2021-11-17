namespace BomberMan
{
    class HealBuff : Items
    {
        public HealBuff() : base("PowerBuff") { }
        public override void Effect(Player player)
        {
            player.HP += 1;
        }
    }

}
