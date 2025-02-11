int attempts = 0;

while (attempts < 3)
{
    string accountNumber = GetAccountNumber();
    if (IsValidAccount(accountNumber))
    {
        TransferMoney(accountNumber);
        break; // Success
    }
    else
    {
        attempts++;
        Console.WriteLine($"Incorrect account number. Attempts remaining: {3 - attempts}");
    }
}

if (attempts == 3)
{
    Console.WriteLine("Too many incorrect attempts. Transfer blocked.");
    // Implement further security measures
}
