namespace WorldOfSoftuniRPG.Models.Items.DefenseItems
{
    using WorldOfSoftuniRPG.Models.Items.UniqueItem;
    using Enumerations;

    public class Chest : DefenceAttack
    {
        private const int CommonAttack = 20;
        private const int UncommonAttack = 40;
        private const int RareAttack = 70;
        private const int MagicAttack = 95;
        private const int LegendaryAttack = 120;

        private const int CommonDefence = 80;
        private const int UncommonDefence = 110;
        private const int RareDefence = 130;
        private const int MagicDefence = 155;
        private const int LegendaryDefence = 180;

        private const ItemType DefaultType = ItemType.Common;

        public Chest(ItemType itemType = DefaultType)
            : base(itemType)
        {
        }

        public override int Defence
        {
            get
            {
                switch (this.ItemType)
                {
                    case ItemType.Common: return Chest.CommonDefence;
                    case ItemType.Uncommon: return Chest.UncommonDefence;
                    case ItemType.Rare: return Chest.RareDefence;
                    case ItemType.Magic: return Chest.MagicDefence;
                    case ItemType.Legendary: return Chest.LegendaryDefence;
                    default: return Chest.CommonDefence;
                }
            }
        }

        public override int Attack
        {
            get
            {
                switch (this.ItemType)
                {
                    case ItemType.Common: return Chest.CommonAttack;
                    case ItemType.Uncommon: return Chest.UncommonAttack;
                    case ItemType.Rare: return Chest.RareAttack;
                    case ItemType.Magic: return Chest.MagicAttack;
                    case ItemType.Legendary: return Chest.LegendaryAttack;
                    default: return Chest.CommonAttack;
                }
            }
        }
    }
}