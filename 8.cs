foreach (var person in raffleParticipants)
{
    if (IsEmployee(person))
    {
        continue; // Skip this person
    }
    // ... process the participant for the raffle
}
