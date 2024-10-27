
int catsCount = int.Parse(Console.ReadLine());

int catsGroupOne = 0;
int catsGroupTwo = 0;
int catsGroupThree = 0;

double gramsForAllCats = 0.0;

for (int i = 0; i < catsCount; i++)
{
    double gramsForCat = double.Parse(Console.ReadLine());

    gramsForAllCats = gramsForAllCats + gramsForCat;

    if (gramsForCat >= 100 && gramsForCat < 200)
    {
        catsGroupOne++;
    } 
    else if (gramsForCat >= 200 && gramsForCat < 300)
    {
        catsGroupTwo++;
    } 
    else if (gramsForCat >= 300 && gramsForCat < 400)
    {
        catsGroupThree++;
    }
}

double foodInKilos = gramsForAllCats / 1000;
double priceForFood = foodInKilos * 12.45;

Console.WriteLine($"Group 1: {catsGroupOne} cats.");
Console.WriteLine($"Group 2: {catsGroupTwo} cats.");
Console.WriteLine($"Group 3: {catsGroupThree} cats.");
Console.WriteLine($"Price for food per day: {priceForFood:f2} lv.");
