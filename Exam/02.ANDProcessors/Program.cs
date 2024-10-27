
int plannedProcessorsCount = int.Parse(Console.ReadLine());
int workingPeopleCount = int.Parse(Console.ReadLine());
int workingDaysCount = int.Parse(Console.ReadLine());

int workingHoursPerDayForOnePerson = 8;
int workingHoursForAllDaysPerPerson = workingDaysCount * workingHoursPerDayForOnePerson;
int workingHoursForAllPeople = workingHoursForAllDaysPerPerson * workingPeopleCount;

double processorsCount = Math.Floor(workingHoursForAllPeople / 3.0);
double difference = processorsCount - plannedProcessorsCount;

if (processorsCount >= plannedProcessorsCount)
{
    Console.WriteLine($"Profit: -> {(difference * 110.10):f2} BGN");
} 
else if (plannedProcessorsCount > processorsCount)
{
    Console.WriteLine($"Losses: -> {(Math.Abs(difference) * 110.10):f2} BGN");
}
