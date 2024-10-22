
double recordInSeconds = double.Parse(Console.ReadLine());
double metersToSwim = double.Parse(Console.ReadLine());
double secondsPerOneMeter = double.Parse(Console.ReadLine());

double totalSecondsToSwimAllMeters = metersToSwim * secondsPerOneMeter;
double delayTimes = Math.Floor(metersToSwim / 15);
totalSecondsToSwimAllMeters = totalSecondsToSwimAllMeters + (delayTimes * 12.5);

double difference = recordInSeconds - totalSecondsToSwimAllMeters;

if (totalSecondsToSwimAllMeters < recordInSeconds)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {totalSecondsToSwimAllMeters:F2} seconds.");
}
else
{
    Console.WriteLine($"No, he failed! He was {Math.Abs(difference):F2} seconds slower.");
}
