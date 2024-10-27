
int pricePerVideocard = int.Parse(Console.ReadLine());
int pricePerJumper = int.Parse(Console.ReadLine());
double priceForUsedCurrentPerVideocard = double.Parse(Console.ReadLine());
double priceReceivedMoneyPerVideocard = double.Parse(Console.ReadLine());

double priceForAllVideocards = pricePerVideocard * 13.0;
double priceForAllJumpers = pricePerJumper * 13.0;
double priceForAllMaterials = priceForAllVideocards + priceForAllJumpers + 1000;

double moneyPerVideocard = priceReceivedMoneyPerVideocard - priceForUsedCurrentPerVideocard;
double gainForAllVideocards = 13 * moneyPerVideocard;
double time = priceForAllMaterials / gainForAllVideocards;

Console.WriteLine(priceForAllMaterials);
Console.WriteLine(Math.Ceiling(time));
