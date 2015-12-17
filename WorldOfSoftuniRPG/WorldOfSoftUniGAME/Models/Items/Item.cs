namespace WorldOfSoftuniRPG.Models.Items
{
    using System.Linq;
    using System.Text;
   
    using Enumerations; 
    using Fields;
    using Interafaces;

    public abstract class Item : IItem
    {
        private const int CommonPrice = 100;
        private const int UncommonPrice = 500;
        private const int RarePrice = 900;
        private const int MagicPrice = 1400;
        private const int LegendaryPrice = 2000;

        protected Item(ItemType itemType)
        {
            this.ItemType = itemType;
        }

        public int Price
        {
            get
            {
                switch (this.ItemType)
                {
                    case ItemType.Common: return Item.CommonPrice;
                    case ItemType.Uncommon: return Item.UncommonPrice;
                    case ItemType.Rare: return Item.RarePrice;
                    case ItemType.Magic: return Item.MagicPrice;
                    case ItemType.Legendary: return Item.LegendaryPrice;
                    default: return Item.CommonPrice;
                }
            }
        }

        public ItemType ItemType { get; set; }

        public static bool IsItemBetter(IItem input)
        {
            return Field.Hero.Inventory.Items.Where(item => item.GetType().Name == input.GetType().Name).Any(item => (int)input.ItemType > (int)item.ItemType);
        }

        public static IItem GetBetterItem(IItem item1, IItem item2)
        {
            if (item1.Price > item2.Price)
            {
                return item1;
            }

            return item2;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            string padding = new string(' ', 2);

            result.Append(padding)
                .Append(this.ItemType);
            result.Append(padding)
                .Append(this.GetType().Name);
            
            return result.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType())
            {
                return false;
            }

            if (((Item)obj).ItemType != this.ItemType)
            {
                return false;
            }

            return true;
        }
    }
}