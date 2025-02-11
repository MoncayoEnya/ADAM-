while (true)
{
    Console.Write("Enter student score: ");
    string input = Console.ReadLine();

    if (double.TryParse(input, out double score))
    {
        if (score >= 0 && score <= 100)
        {
            break; // Valid score
        }
        else
        {
            Console.WriteLine("Invalid score. Please enter a score between 0 and 100.");
        }
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a number.");
    }
}
