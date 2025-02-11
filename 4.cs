int steps = 0;

while (true)
{
    steps = GetStepCount(); // Get latest step count

    if (steps >= 10000)
    {
        Console.WriteLine("Congratulations! You've reached 10,000 steps!");
        // You might reset steps here or implement other logic
    }

    // ... other app functionalities
    Thread.Sleep(60000); // Check every minute (adjust interval as needed)
}
