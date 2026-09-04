public class Player
{
    public string name { get; set; }
    public int health { get; set; } = 100; 

    public Player ( string Name)
    {
        name = Name;
    }

}