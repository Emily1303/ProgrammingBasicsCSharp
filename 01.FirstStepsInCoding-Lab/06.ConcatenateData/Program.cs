
string firstName = Console.ReadLine();
string lastName = Console.ReadLine();
int age = int.Parse(Console.ReadLine());
string town = Console.ReadLine();

// First way 
Console.WriteLine($"You are {firstName} {lastName}, a {age}-years old person from {town}.");

// Second way 
//string output = "You are " + firstName + " " + lastName + ", a " + age + "-years old person from " + town + ".";
//Console.WriteLine(output);

