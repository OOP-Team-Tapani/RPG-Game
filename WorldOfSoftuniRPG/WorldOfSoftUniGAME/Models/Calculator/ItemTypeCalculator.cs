namespace WorldOfSoftuniRPG.Models.Calculator
{
    using Enumerations;

    internal static class ItemTypeCalculator
    {
        private const decimal UncommonMultiply = 1.1m;
        private const decimal RareMultiply = 1.2m;
        private const decimal MagicMultiply = 1.3m;
        private const decimal LegendaryMultiply = 1.4m;

        public static decimal CalculateByItemType(ItemType itemType, decimal value)
        {
            decimal multiply = 1;

            switch (itemType)
            {
                case ItemType.Uncommon:
                    multiply = UncommonMultiply;
                    break;
                case ItemType.Rare:
                    multiply = RareMultiply;
                    break;
                case ItemType.Magic:
                    multiply = MagicMultiply;
                    break;
                case ItemType.Legendary:
                    multiply = LegendaryMultiply;
                    break;
            }

            decimal newAttack = value * multiply;

            return newAttack;
        }
    }
}
