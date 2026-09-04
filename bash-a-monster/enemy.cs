public class Enemy
{
    public string name { get; set; }
    public int health { get; set; } 

    public Enemy ( string Name, int Health)
    {
        name = Name;
        health = Health;
    }

}