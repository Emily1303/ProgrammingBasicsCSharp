
double age = double.Parse(Console.ReadLine());
char gender = char.Parse(Console.ReadLine());

string personalTitle = "";
if (gender == 'm' && age >= 16)
{
    personalTitle = "Mr.";
} 
else if (gender == 'm' && age < 16) 
{
    personalTitle = "Master";
}
else if (gender == 'f' && age >= 16)
{
    personalTitle = "Ms.";
}
else if (gender == 'f' && age < 16) 
{
    personalTitle = "Miss";
}

Console.WriteLine(personalTitle);
