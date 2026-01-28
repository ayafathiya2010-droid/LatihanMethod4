using System.ComponentModel.Design;

int health = 100;

void takedamage(int damage)
{
    health = health - damage;
}

takedamage(5);
Console.WriteLine($"Current health: {health}"