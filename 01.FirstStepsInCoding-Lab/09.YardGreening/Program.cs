
double placeForGreening = double.Parse(Console.ReadLine());
double priceWithoutDiscount = placeForGreening * 7.61;
double discount = priceWithoutDiscount * 0.18;
double totalPrice = priceWithoutDiscount - discount;

Console.WriteLine($"The final price is: {totalPrice} lv.");
Console.WriteLine($"The discount is: {discount} lv.");

