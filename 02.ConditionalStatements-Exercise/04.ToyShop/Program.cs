
double tourPrice = double.Parse(Console.ReadLine());
int puzzleCount = int.Parse(Console.ReadLine());
int dollsCount = int.Parse(Console.ReadLine());
int teddyBearsCount = int.Parse(Console.ReadLine());
int minionsCount = int.Parse(Console.ReadLine());
int trucksCount = int.Parse(Console.ReadLine());

double pricePerPuzzle = 2.60;
double pricePerDoll = 3.0;
double pricePerTeddyBear = 4.10;
double pricePerMinion = 8.20;
double pricePerTruck = 2.0;

double totalPriceWithoutDiscounts = pricePerPuzzle * puzzleCount + pricePerDoll * dollsCount + pricePerTeddyBear * teddyBearsCount + pricePerMinion * minionsCount + pricePerTruck * trucksCount;

int totalCountToys = puzzleCount + dollsCount + teddyBearsCount + minionsCount + trucksCount;

double priceForToys = 0.0;
if (totalCountToys >= 50)
{
    priceForToys = totalPriceWithoutDiscounts - (totalPriceWithoutDiscounts * 0.25);
}
else
{
    priceForToys = totalPriceWithoutDiscounts;
}

priceForToys = priceForToys - (priceForToys * 0.10);

double diffrerence = tourPrice - priceForToys;

if (tourPrice <= priceForToys)
{
    Console.WriteLine($"Yes! {Math.Abs(diffrerence):F2} lv left.");
}
else
{
    Console.WriteLine($"Not enough money! {diffrerence:F2} lv needed.");
}

