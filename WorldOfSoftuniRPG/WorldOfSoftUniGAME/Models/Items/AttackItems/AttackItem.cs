namespace WorldOfSoftuniRPG.Models.Items.AttackItems
{
    using System.Text;
    using Enumerations;

    public abstract class AttackItem : Item
    {
        protected AttackItem(ItemType itemType)
            : base(itemType)
        {
        }

        public abstract int Attack { get; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());
            result.Append("  Attack: ").Append(this.Attack.ToString());

            return result.ToString();
        }

        public override int GetHashCode()
        {
            int hash = base.GetHashCode();

            hash = (hash * 23) + this.Attack.GetHashCode();

            return hash;
        }
    }
}