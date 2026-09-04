Player player = new Player("Tuge");
Enemy enemy = new Enemy("Rat", 50);

Console.WriteLine($"{enemy.name} have {enemy.health} health");

enemy.health -= 10;
Console.WriteLine($"{enemy.name}got damaged, {enemy.health} left");

Console.ReadLine();