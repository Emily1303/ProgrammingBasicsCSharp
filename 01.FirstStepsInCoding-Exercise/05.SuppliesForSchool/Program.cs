
int packetsPens = int.Parse(Console.ReadLine());
int packetsMarkers = int.Parse(Console.ReadLine());
int litersCleaner = int.Parse(Console.ReadLine());
int percentDiscount = int.Parse(Console.ReadLine());

// Prices
double pricePerPacketPens = 5.80;
double pricePerPacketMarkers = 7.20;
double pricePerLitreCleaner = 1.20;

double priceWithoutDiscount = packetsPens * pricePerPacketPens + packetsMarkers * pricePerPacketMarkers +
    litersCleaner * pricePerLitreCleaner;
double discount = priceWithoutDiscount * percentDiscount / 100;
double totalPrice = priceWithoutDiscount - discount;

Console.WriteLine(totalPrice);
