string customerType = "VIP"; // Or "Regular"
double amountSpent = 150;
double points = 0;

if (customerType == "VIP")
{
    points = amountSpent > 100 ? amountSpent * 2 : amountSpent * 1.5;
}
else if (customerType == "Regular")
{
    points = amountSpent > 100 ? amountSpent * 1.5 : amountSpent;
}

Console.WriteLine($"You earned {points} points.");
