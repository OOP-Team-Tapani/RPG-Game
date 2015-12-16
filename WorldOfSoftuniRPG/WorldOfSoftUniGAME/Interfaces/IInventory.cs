namespace WorldOfSoftuniRPG.Interafaces
{
    public interface IInventory
    {
        void AddItem(IItem item);

        void RemoveItem(IItem item);

        string ShowItems();
    }
}