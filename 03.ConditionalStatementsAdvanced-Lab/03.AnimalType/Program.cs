
string animal = Console.ReadLine();

string animalClass = "";
switch (animal)
{
    case "dog":
        animalClass = "mammal";
        break;
    case "crocodile":
    case "tortoise":
    case "snake":
        animalClass = "reptile";
        break;
    default:
        animalClass = "unknown";
        break;
}

Console.WriteLine(animalClass);
