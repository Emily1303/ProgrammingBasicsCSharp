
int chickenMenusCount = int.Parse(Console.ReadLine());
int fishMenusCount = int.Parse(Console.ReadLine());
int vegetarianMenusCount = int.Parse(Console.ReadLine());

// Prices 
double pricePerChickenMenu = 10.35;
double pricePerFishMenu = 12.40;
double pricePerVegetarianMenu = 8.15;
double delivery = 2.50;

double price = chickenMenusCount * pricePerChickenMenu + fishMenusCount * pricePerFishMenu +
    vegetarianMenusCount * pricePerVegetarianMenu;
double dessert = price * 0.20;
double totalSum = price + dessert + delivery;

Console.WriteLine(totalSum);

