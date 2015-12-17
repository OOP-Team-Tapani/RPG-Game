namespace WorldOfSoftuniRPG.Models.Items.DefenseItems
{
    using WorldOfSoftuniRPG.Models.Items.UniqueItem;
    using Enumerations;

    public class Pants : DefenceAttack
    {
        private const int CommonAttack = 30;
        private const int UncommonAttack = 50;
        private const int RareAttack = 85;
        private const int MagicAttack = 110;
        private const int LegendaryAttack = 135;

        private const int CommonDefence = 70;
        private const int UncommonDefence = 100;
        private const int RareDefence = 115;
        private const int MagicDefence = 140;
        private const int LegendaryDefence = 165;

        private const ItemType DefaultType = ItemType.Common;

        public Pants(ItemType itemType = DefaultType)
            : base(itemType)
        {
        }

        public override int Defence
        {
            get
            {
                switch (this.ItemType)
                {
                    case ItemType.Common: return Pants.CommonDefence;
                    case ItemType.Uncommon: return Pants.UncommonDefence;
                    case ItemType.Rare: return Pants.RareDefence;
                    case ItemType.Magic: return Pants.MagicDefence;
                    case ItemType.Legendary: return Pants.LegendaryDefence;
                    default: return Pants.CommonDefence;
                }
            }
        }

        public override int Attack
        {
            get
            {
                switch (this.ItemType)
                {
                    case ItemType.Common: return Pants.CommonAttack;
                    case ItemType.Uncommon: return Pants.UncommonAttack;
                    case ItemType.Rare: return Pants.RareAttack;
                    case ItemType.Magic: return Pants.MagicAttack;
                    case ItemType.Legendary: return Pants.LegendaryAttack;
                    default: return Pants.CommonAttack;
                }
            }
        }
    }
}