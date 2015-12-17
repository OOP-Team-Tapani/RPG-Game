namespace WorldOfSoftuniRPG.Models.Items.AttackItems
{
    using Enumerations;

    public class Sword : AttackItem
    {
        private const int CommonAttack = 100;
        private const int UncommonAttack = 150;
        private const int RareAttack = 200;
        private const int MagicAttack = 250;
        private const int LegendaryAttack = 300;

        private const ItemType DefaultType = ItemType.Common;

        public Sword(ItemType itemType = DefaultType)
            : base(itemType)
        {
        }

        public override int Attack
        {
            get
            {
                switch (this.ItemType)
                {
                    case ItemType.Common: return Sword.CommonAttack;
                    case ItemType.Uncommon: return Sword.UncommonAttack;
                    case ItemType.Rare: return Sword.RareAttack;
                    case ItemType.Magic: return Sword.MagicAttack;
                    case ItemType.Legendary: return Sword.LegendaryAttack;
                    default: return Sword.CommonAttack;
                }
            }
        }
    }
}