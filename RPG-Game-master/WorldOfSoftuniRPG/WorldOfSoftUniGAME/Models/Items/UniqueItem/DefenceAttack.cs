namespace WorldOfSoftuniRPG.Models.Items.UniqueItem
{
    using System.Text;

    using Enumerations;

    public abstract class DefenceAttack : Item
    {
        protected DefenceAttack(ItemType itemType)
            : base(itemType)
        {
        }

        public abstract int Attack { get; }

        public abstract int Defence { get; }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());
            result.Append("  Attack: ").Append(this.Attack.ToString()); 
            result.Append("  Defence: ").Append(this.Defence.ToString());

            return result.ToString();
        }
    }
}
