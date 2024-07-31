// Dice rolling simulation -- Create decision logic with if statements
Random dice = new();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);
int total = roll1 + roll2 + roll3;

Console.WriteLine($"\nDice roll: {roll1} + {roll2} + {roll3} = {total} ");

if (roll1 == roll2 && roll2 == roll3)
{
    total += 6;
    Console.WriteLine("You rolled triples! +6 bonus to total! Currently total: " + total);
}
else if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    total += 2;
    Console.WriteLine("You rolled double! +2 bonus to total! Currently total: " + total);
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}