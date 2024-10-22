
int hour = int.Parse(Console.ReadLine());
int minutes = int.Parse(Console.ReadLine());

int allMinutes = minutes + 15;
if (allMinutes >= 60)
{
    hour = hour + (allMinutes / 60);
    minutes = allMinutes % 60;
}
else
{
    minutes = allMinutes;
}

if (hour == 24)
{
    hour = 0;
}

if (minutes < 10)
{
    Console.WriteLine($"{hour}:0{minutes}");
}
else
{
    Console.WriteLine($"{hour}:{minutes}");
}
