Player player = new Player("Tuge");
Enemy enemy = new Enemy("Rat", 50);

Console.WriteLine($"{enemy.name} have {enemy.health} health");

enemy.health -= 10;
Console.WriteLine($"{enemy.name} got damaged, {enemy.health} left");
Console.WriteLine($"{player.name} have, {player.health} health");

player.health += 10;
Console.WriteLine($"{player.name} got, {player.health} health");

Console.ReadLine();