
double budget = double.Parse(Console.ReadLine());
int peopleCount = int.Parse(Console.ReadLine());
double pricePerCostumeForOnePerson = double.Parse(Console.ReadLine());

double priceDecor = budget * 0.10;
double priceForCostumes = peopleCount * pricePerCostumeForOnePerson;

if (peopleCount > 150)
{
    priceForCostumes = priceForCostumes - (priceForCostumes * 0.10);
}

double neededMoney = priceForCostumes + priceDecor;
double difference = budget - neededMoney;

if (neededMoney > budget)
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {Math.Abs(difference):F2} leva more.");
}
else
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {difference:F2} leva left.");
}
