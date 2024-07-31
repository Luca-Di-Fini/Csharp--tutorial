Random random = new();

int daysUntilExpiration = random.Next(1, 12);
int discountPercentage = 0; // Inizializzazione della variabile

Console.WriteLine("Days to expiration : " + daysUntilExpiration);

if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
    Console.WriteLine($"Your subscription expires within a day! Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save {discountPercentage}%!");
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}
else
{
    Console.WriteLine("Your subscription has expired.");
}
