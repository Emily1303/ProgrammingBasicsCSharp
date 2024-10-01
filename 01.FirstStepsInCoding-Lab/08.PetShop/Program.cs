
int foodForDogsCount = int.Parse(Console.ReadLine());
int foodForCatsCount = int.Parse(Console.ReadLine());

double foodDogsPrice = foodForDogsCount * 2.50;
double foodCatsPrice = foodForCatsCount * 4;
double totalPrice = foodDogsPrice + foodCatsPrice;

Console.WriteLine($"{totalPrice} lv.");
