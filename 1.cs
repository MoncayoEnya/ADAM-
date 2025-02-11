while (true)
{
    DisplayMenu();
    string choice = GetUserChoice();

    switch (choice)
    {
        case "exit":
            break; // Exit the loop
        case "order":
            ProcessOrder();
            break;
        case "specials":
            ShowSpecials();
            break;
        default:
            Console.WriteLine("Invalid choice.");
            break;
    }

    if (choice == "exit") break; //needed because switch only breaks out of case
}

// ... (Menu display and other functions)
