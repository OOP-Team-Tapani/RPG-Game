namespace WorldOfSoftuniRPG.Models.Fields
{
    using System.Collections.Generic;

    using Interafaces;
    using System;

    public class Inventory
    {
        private List<IItem> items = new List<IItem>();

        public List<IItem> Items
        {
            get
            {
                return this.items;
            }

            set
            {
                this.items = value;
            }
        }

        public int SameTypeIndex(IItem item)
        {
            foreach (var inventoryItem in this.Items)
            {
                if (inventoryItem.GetType() == item.GetType())
                {
                    return this.Items.IndexOf(inventoryItem);
                }
            }

            return -1;
        }

        public override string ToString()
        {
            
            string inventoryInfo = string.Join(" ", this.Items);
            return inventoryInfo;
        }
    }
}