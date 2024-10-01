
string architectName = Console.ReadLine();
int projectCount = int.Parse(Console.ReadLine());

int hoursNeeded = projectCount * 3;

Console.WriteLine($"The architect {architectName} will need {hoursNeeded} " +
    $"hours to complete {projectCount} project/s.");
