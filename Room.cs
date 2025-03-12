namespace DungeonExplorer
{
    public class Room
    {
       public string Description { get; set; }
        public string Item { get; set; }

        public Room(string description, string item)
        {
            Description = description;
            Item = item;
        }
    }
}