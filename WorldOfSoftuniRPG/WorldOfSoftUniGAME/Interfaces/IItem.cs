namespace WorldOfSoftuniRPG.Interafaces
{
    using WorldOfSoftuniRPG.Enumerations;

    public interface IItem
    {
        int Price
        {
            get;
        }

        ItemType ItemType
        {
            get;
            set;
        }
    }
}