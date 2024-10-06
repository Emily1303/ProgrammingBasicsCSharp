
double deposit = double.Parse(Console.ReadLine());
int monthsOfDeposit = int.Parse(Console.ReadLine());
double percentagePerYear = double.Parse(Console.ReadLine());

double sum = deposit + monthsOfDeposit * ((deposit * (percentagePerYear / 100)) / 12);

Console.WriteLine(sum);
