
string dayOfWeek = Console.ReadLine();

string kindOfDay = "";
switch (dayOfWeek)
{
    case "Monday":
    case "Tuesday":
    case "Wednesday":
    case "Thursday":
    case "Friday":
        kindOfDay = "Working day";
        break;
    case "Saturday":
    case "Sunday":
        kindOfDay = "Weekend";
        break;
    default:
        kindOfDay = "Error";
        break;
}

Console.WriteLine(kindOfDay);
