while (true)
{
    Console.Write("Enter number of tickets: ");
    string input = Console.ReadLine();

    if (int.TryParse(input, out int numTickets))
    {
        if (numTickets >= 0)
        {
            break; // Valid input
        }
        else
        {
            Console.WriteLine("Number of tickets cannot be negative.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }
}

// ... (Continue with booking process using numTickets)
