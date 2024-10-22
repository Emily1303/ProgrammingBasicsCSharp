
int secondsFirstPerson = int.Parse(Console.ReadLine());
int secondsSecondPerson = int.Parse(Console.ReadLine());
int secondsThirdPerson = int.Parse(Console.ReadLine());

int allSeconds = secondsFirstPerson + secondsSecondPerson + secondsThirdPerson;
int timeInMinutes = allSeconds / 60;
int timeInSeconds = allSeconds % 60;

if (timeInSeconds < 10)
{
    Console.WriteLine($"{timeInMinutes}:0{timeInSeconds}");
}
else
{
    Console.WriteLine($"{timeInMinutes}:{timeInSeconds}");
}
