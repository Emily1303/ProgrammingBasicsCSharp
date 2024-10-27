
string input = Console.ReadLine();

int kids = 0;
int adults = 0;

while (input != "Christmas")
{
    int age = int.Parse(input);

    if (age <= 16)
    {
        kids++;
    } 
    else if (age > 16)
    {
        adults++;
    }

    input = Console.ReadLine();
}

double pricePerToy = 5.00;
double pricePerSweater = 15.00;

double totalPriceForToys = kids * pricePerToy;
double totalPriceForSweaters = adults * pricePerSweater;

Console.WriteLine($"Number of adults: {adults}");
Console.WriteLine($"Number of kids: {kids}");
Console.WriteLine($"Money for toys: {totalPriceForToys:f0}");
Console.WriteLine($"Money for sweaters: {totalPriceForSweaters:f0}");
