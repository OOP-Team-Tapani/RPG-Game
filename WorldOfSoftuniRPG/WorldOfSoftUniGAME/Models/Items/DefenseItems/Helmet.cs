namespace WorldOfSoftuniRPG.Models.Items.DefenseItems
{
    using Enumerations;

    public class Helmet : DefenseItem
    {
        private const int CommonDefence = 100;
        private const int UncommonDefence = 150;
        private const int RareDefence = 200;
        private const int MagicDefence = 250;
        private const int LegendaryDefence = 300;

        private const ItemType DefaultType = ItemType.Common;

        public Helmet(ItemType itemType = DefaultType)
            : base(itemType)
        {
        }

        public override int Defence
        {
            get
            {
                switch (this.ItemType)
                {
                    case ItemType.Common: return Helmet.CommonDefence;
                    case ItemType.Uncommon: return Helmet.UncommonDefence;
                    case ItemType.Rare: return Helmet.RareDefence;
                    case ItemType.Magic: return Helmet.MagicDefence;
                    case ItemType.Legendary: return Helmet.LegendaryDefence;
                    default: return Helmet.CommonDefence;
                }
            }
        }
    }
}