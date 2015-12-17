namespace WorldOfSoftuniRPG.Models.Items.HealthItems
{
    using Enumerations;
    using Fields;
    using Interafaces;

    internal class Potion : Item, IHeal
    {
        public Potion(ItemType itemType)
            : base(itemType)
        {
            switch (itemType)
            {
                case ItemType.Common:
                    this.Health = 20;
                    break;
                case ItemType.Uncommon:
                    this.Health = 40;
                    break;
                case ItemType.Rare:
                    this.Health = 60;
                    break;
                case ItemType.Magic:
                    this.Health = 80;
                    break;
                case ItemType.Legendary:
                    this.Health = 100;
                    break;
            }
        }

        public int Health { get; set; }

        public void Heal()
        {
            Field.Hero.Health += this.Health;
            if (Field.Hero.Health > 100)
            {
                Field.Hero.Health = 100;
            }
        }
    }
}