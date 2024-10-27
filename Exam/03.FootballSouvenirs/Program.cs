
string footballTeam = Console.ReadLine();
string souvenirs = Console.ReadLine();
int boughtSouvenirsCount = int.Parse(Console.ReadLine());

double price = 0.0;

bool isInvalid = false;

switch (footballTeam)
{
    case "Argentina":
        if (souvenirs == "flags")
        {
            price = boughtSouvenirsCount * 3.25;
        } 
        else if (souvenirs == "caps")
        {
            price = boughtSouvenirsCount * 7.20;
        } 
        else if (souvenirs == "posters")
        {
            price = boughtSouvenirsCount * 5.10;
        } 
        else if (souvenirs == "stickers")
        {
            price = boughtSouvenirsCount * 1.25;
        } 
        else
        {
            isInvalid = true;
            Console.WriteLine("Invalid stock!");
        }

        break;
    case "Brazil":
        if (souvenirs == "flags")
        {
            price = boughtSouvenirsCount * 4.20;
        } 
        else if (souvenirs == "caps")
        {
            price = boughtSouvenirsCount * 8.50;
        } 
        else if (souvenirs == "posters")
        {
            price = boughtSouvenirsCount * 5.35;
        } 
        else if (souvenirs == "stickers")
        {
            price = boughtSouvenirsCount * 1.20;
        } 
        else
        {
            isInvalid = true;
            Console.WriteLine("Invalid stock!");
        }

        break;
    case "Croatia":
        if (souvenirs == "flags")
        {
            price = boughtSouvenirsCount * 2.75;
        }
        else if (souvenirs == "caps")
        {
            price = boughtSouvenirsCount * 6.90;
        }
        else if (souvenirs == "posters")
        {
            price = boughtSouvenirsCount * 4.95;
        }
        else if (souvenirs == "stickers")
        {
            price = boughtSouvenirsCount * 1.10;
        }
        else
        {
            isInvalid = true;
            Console.WriteLine("Invalid stock!");
        }

        break;
    case "Denmark":
        if (souvenirs == "flags")
        {
            price = boughtSouvenirsCount * 3.10;
        }
        else if (souvenirs == "caps")
        {
            price = boughtSouvenirsCount * 6.50;
        }
        else if (souvenirs == "posters")
        {
            price = boughtSouvenirsCount * 4.80;
        }
        else if (souvenirs == "stickers")
        {
            price = boughtSouvenirsCount * 0.90;
        }
        else
        {
            isInvalid = true;
            Console.WriteLine("Invalid stock!");
        }

        break;
    default:
        isInvalid = true;
        Console.WriteLine("Invalid country!");
        break;
}

if (!isInvalid)
{
    Console.WriteLine($"Pepi bought {boughtSouvenirsCount} {souvenirs} of {footballTeam} for {price:f2} lv.");
}
