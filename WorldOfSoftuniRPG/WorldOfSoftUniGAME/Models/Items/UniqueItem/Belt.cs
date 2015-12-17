namespace WorldOfSoftuniRPG.Models.Items.AttackItems
{
    using WorldOfSoftuniRPG.Interafaces;
    using WorldOfSoftuniRPG.Models.Items.UniqueItem;
    using Enumerations;

    public class Belt : DefenceAttack
    { 
        private const int CommonAttack = 75;
        private const int UncommonAttack = 100;
        private const int RareAttack = 135;
        private const int MagicAttack = 160;
        private const int LegendaryAttack = 185;

        private const int CommonDefence = 25;
        private const int UncommonDefence = 50;
        private const int RareDefence = 80;
        private const int MagicDefence = 90;
        private const int LegendaryDefence = 115;

        private const ItemType DefaultType = ItemType.Common;

        public Belt(ItemType itemType = DefaultType)
            : base(itemType)
        {
        }

        public override int Defence
        {
            get
            {
                switch (this.ItemType)
                {
                    case ItemType.Common: return Belt.CommonDefence;
                    case ItemType.Uncommon: return Belt.UncommonDefence;
                    case ItemType.Rare: return Belt.RareDefence;
                    case ItemType.Magic: return Belt.MagicDefence;
                    case ItemType.Legendary: return Belt.LegendaryDefence;
                    default: return Belt.CommonDefence;
                }
            }
        }

        public override int Attack
        {
            get
            {
                switch (this.ItemType)
                {
                    case ItemType.Common: return Belt.CommonAttack;
                    case ItemType.Uncommon: return Belt.UncommonAttack;
                    case ItemType.Rare: return Belt.RareAttack;
                    case ItemType.Magic: return Belt.MagicAttack;
                    case ItemType.Legendary: return Belt.LegendaryAttack;
                    default: return Belt.CommonAttack;
                }
            }
        }
    }
}