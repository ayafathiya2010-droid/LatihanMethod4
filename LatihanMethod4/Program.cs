using System.ComponentModel.Design;

int health = 100;

void takedamage(int damage)
{
    int health = 50;
    health = health - damage;
    Console.WriteLine($"Current health: {health}");
}

takedamage(5);
Console.WriteLine($"Current health: {health}");