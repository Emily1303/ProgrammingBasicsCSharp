
string seriesName = Console.ReadLine();
int episodeTime = int.Parse(Console.ReadLine());
int breakTime = int.Parse(Console.ReadLine());

double lunchTime = breakTime / 8.0;
double freeTime = breakTime / 4.0;

double timeRemaining = breakTime - (lunchTime + freeTime);
double difference = timeRemaining - episodeTime;

if (timeRemaining >= episodeTime)
{
    Console.WriteLine($"You have enough time to watch {seriesName} and " +
        $"left with {Math.Ceiling(difference)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {seriesName}, " +
        $"you need {Math.Ceiling(Math.Abs(difference))} more minutes.");
}
