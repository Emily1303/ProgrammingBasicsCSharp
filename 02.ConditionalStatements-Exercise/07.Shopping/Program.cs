
double budget = double.Parse(Console.ReadLine());
int videocardsCount = int.Parse(Console.ReadLine());
int cpuCount = int.Parse(Console.ReadLine());
int ramCount = int.Parse(Console.ReadLine());

double priceForVideocards = videocardsCount * 250;
double priceForCpus = cpuCount * (priceForVideocards * 0.35);
double priceForRam = ramCount * (priceForVideocards * 0.10);
double totalSum = priceForVideocards + priceForCpus + priceForRam;

if (videocardsCount > cpuCount)
{
    totalSum = totalSum - (totalSum * 0.15);
}

double difference = budget - totalSum;

if (budget >= totalSum)
{
    Console.WriteLine($"You have {difference:F2} leva left!");
}
else
{
    Console.WriteLine($"Not enough money! You need {Math.Abs(difference):F2} leva more!");
}
