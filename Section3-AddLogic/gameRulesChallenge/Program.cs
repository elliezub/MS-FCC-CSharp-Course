int heroHealth = 10;
int monsterHealth = 10;

Random random= new Random();

do
{
    int attackDamage = random.Next(1, 11);
    monsterHealth -= attackDamage;
    Console.WriteLine($"The monster was damaged and lost {attackDamage} health and now has {monsterHealth} health.");

    if (monsterHealth > 0)
    {
        attackDamage = random.Next(1, 11);
        heroHealth -= attackDamage;
        Console.WriteLine($"The hero was damaged and lost {attackDamage} health and now has {heroHealth} health.");
    }
} while (heroHealth > 0 && monsterHealth > 0);

if (heroHealth > 0)
    Console.WriteLine($"The hero is the winner with {heroHealth} health remaining!");
else if (monsterHealth > 0)
    Console.WriteLine($"The monster is the winner with {monsterHealth} health remaining!");
    