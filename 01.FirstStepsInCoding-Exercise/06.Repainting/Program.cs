
int needeNylonInM2 = int.Parse(Console.ReadLine());
int neededDyeInLiters = int.Parse(Console.ReadLine());
int neededDyeThinnerInLiters = int.Parse(Console.ReadLine());
int hoursForWorkmen = int.Parse(Console.ReadLine());

// Prices 
double priceNylonPerM2 = 1.50;
double priceDyePerLiter = 14.50;
double priceDyeThinnerPerLiter = 5.0;
double priceBags = 0.40;

double priceMaterials = needeNylonInM2 * priceNylonPerM2 + neededDyeInLiters * priceDyePerLiter
    + neededDyeThinnerInLiters * priceDyeThinnerPerLiter;
double extraDye = neededDyeInLiters * 0.1;
double priceExtraMaterials = extraDye * priceDyePerLiter + 2 * priceNylonPerM2 + priceBags;
double totalPriceForMaterials = priceExtraMaterials + priceMaterials;
double priceWorkmenPerHour = totalPriceForMaterials * 0.30;
double totalPriceForWorkmen = hoursForWorkmen * priceWorkmenPerHour;

Console.WriteLine(totalPriceForMaterials + totalPriceForWorkmen);

