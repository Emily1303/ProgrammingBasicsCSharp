
string dayOfWeek = Console.ReadLine();

double priceOfTicket = 0.0;

switch (dayOfWeek)
{
    case "Monday":
        priceOfTicket = 12;
        break;
    case "Tuesday":
        priceOfTicket = 12;
        break;
    case "Wednesday":
        priceOfTicket = 14;
        break;
    case "Thursday":
        priceOfTicket = 14;
        break;
    case "Friday":
        priceOfTicket = 12;
        break;
    case "Saturday":
        priceOfTicket = 16;
        break;
    case "Sunday":
        priceOfTicket = 16;
        break;
}

Console.WriteLine(priceOfTicket);
