// Modifying directly (pass by reference - ref keyword could be used for extra clarity, but is not strictly necessary in this case)
static double WithdrawMoneyDirect(double balance, double amount)
{
    if (amount <= balance)
    {
        balance -= amount;
        return balance;
    }
    return balance;
}

// Returning a new balance
static double WithdrawMoneyNew(double balance, double amount)
{
    if (amount <= balance)
    {
        double newBalance = balance - amount;
        return newBalance;
    }
    return balance;
}


// Example Usage
double currentBalance = 100;
double newBalance = WithdrawMoneyNew(currentBalance, 50); // currentBalance is still 100
currentBalance = WithdrawMoneyDirect(currentBalance, 50); // currentBalance is now 50
