
int basketballFee = int.Parse(Console.ReadLine());

double priceShoes = basketballFee - (basketballFee * 0.40);
double priceOutfit = priceShoes - (priceShoes * 0.20);
double priceBasketBall = priceOutfit / 4;
double priceAccessories = priceBasketBall / 5;

double totalSum = basketballFee + priceShoes + priceOutfit + priceBasketBall + priceAccessories;
Console.WriteLine(totalSum);
