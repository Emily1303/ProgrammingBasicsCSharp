
int locationsCount = int.Parse(Console.ReadLine());

for (int i = 0; i < locationsCount; i++)
{
    double plannedGoldPerDay = double.Parse(Console.ReadLine());
    int daysMiningPerLocation = int.Parse(Console.ReadLine());

    double totalGoldForAllDays = 0.0;

    for (int j = 0; j < daysMiningPerLocation; j++)
    {
        double goldForTheDay = double.Parse(Console.ReadLine());

        totalGoldForAllDays = totalGoldForAllDays + goldForTheDay;
    }

    double goldPerDayAfterMining = totalGoldForAllDays / daysMiningPerLocation;

    double difference = plannedGoldPerDay - goldPerDayAfterMining;

    if (goldPerDayAfterMining >= plannedGoldPerDay)
    {
        Console.WriteLine($"Good job! Average gold per day: {goldPerDayAfterMining:f2}.");
    } 
    else if (goldPerDayAfterMining < plannedGoldPerDay)
    {
        Console.WriteLine($"You need {difference:f2} gold.");
    }
}
