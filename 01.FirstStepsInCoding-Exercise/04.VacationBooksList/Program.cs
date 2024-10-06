
int allPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int daysToReadTheBook = int.Parse(Console.ReadLine());

int hoursToReadTheBook = allPages / pagesPerHour;
int hoursPerDay = hoursToReadTheBook / daysToReadTheBook;

Console.WriteLine(hoursPerDay);
