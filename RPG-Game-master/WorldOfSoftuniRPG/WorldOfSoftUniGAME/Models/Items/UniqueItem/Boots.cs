namespace WorldOfSoftuniRPG.Models.Items.AttackItems
{
    using WorldOfSoftuniRPG.Models.Items.UniqueItem;
    using Enumerations;

    public class Boots : DefenceAttack
    {
        private const int CommonAttack = 60;
        private const int UncommonAttack = 85;
        private const int RareAttack = 120;
        private const int MagicAttack = 145;
        private const int LegendaryAttack = 170;

        private const int CommonDefence = 40;
        private const int UncommonDefence = 65;
        private const int RareDefence = 80;
        private const int MagicDefence = 105;
        private const int LegendaryDefence = 130;

        private const ItemType DefaultType = ItemType.Common;

        public Boots(ItemType itemType = DefaultType)
            : base(itemType)
        {
        }

        public override int Defence
        {
            get
            {
                switch (this.ItemType)
                {
                    case ItemType.Common: return Boots.CommonDefence;
                    case ItemType.Uncommon: return Boots.UncommonDefence;
                    case ItemType.Rare: return Boots.RareDefence;
                    case ItemType.Magic: return Boots.MagicDefence;
                    case ItemType.Legendary: return Boots.LegendaryDefence;
                    default: return Boots.CommonDefence;
                }
            }
        }

        public override int Attack
        {
            get
            {
                switch (this.ItemType)
                {
                    case ItemType.Common: return Boots.CommonAttack;
                    case ItemType.Uncommon: return Boots.UncommonAttack;
                    case ItemType.Rare: return Boots.RareAttack;
                    case ItemType.Magic: return Boots.MagicAttack;
                    case ItemType.Legendary: return Boots.LegendaryAttack;
                    default: return Boots.CommonAttack;
                }
            }
        }
    }
}