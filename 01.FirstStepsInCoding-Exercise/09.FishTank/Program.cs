
int lengthInCm = int.Parse(Console.ReadLine());
int widthInCm = int.Parse(Console.ReadLine());
int heightInCm = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

int volumeInCm = lengthInCm * widthInCm * heightInCm;
double volumeInLiters = volumeInCm / 1000.0;
double volumeOtherThings = volumeInLiters * percent / 100;
double litersWaterForTheAquarium = volumeInLiters - volumeOtherThings;

Console.WriteLine(litersWaterForTheAquarium);
