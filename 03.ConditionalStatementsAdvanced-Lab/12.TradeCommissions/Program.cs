
string city = Console.ReadLine();
double sales = double.Parse(Console.ReadLine());

bool isInvalid = false;

double commissions = 0.0;

if (city == "Sofia")
{
    if (sales >= 0 && sales <= 500)
    {
        commissions = sales * 0.05;
    } 
    else if (sales > 500 && sales <= 1000)
    {
        commissions = sales * 0.07;
    } 
    else if (sales > 1000 && sales <= 10000)
    {
        commissions = sales * 0.08;
    } 
    else if (sales > 10000)
    {
        commissions = sales * 0.12;
    } 
    else
    {
        isInvalid = true;
    }
} 
else if (city == "Varna")
{
    if (sales >= 0 && sales <= 500)
    {
        commissions = sales * 0.045;
    }
    else if (sales > 500 && sales <= 1000)
    {
        commissions = sales * 0.075;
    }
    else if (sales > 1000 && sales <= 10000)
    {
        commissions = sales * 0.10;
    }
    else if (sales > 10000)
    {
        commissions = sales * 0.13;
    }
    else
    {
        isInvalid = true;
    }
} 
else if (city == "Plovdiv")
{
    if (sales >= 0 && sales <= 500)
    {
        commissions = sales * 0.055;
    }
    else if (sales > 500 && sales <= 1000)
    {
        commissions = sales * 0.08;
    }
    else if (sales > 1000 && sales <= 10000)
    {
        commissions = sales * 0.12;
    }
    else if (sales > 10000)
    {
        commissions = sales * 0.145;
    }
    else
    {
        isInvalid = true;
    }
} 
else
{
    isInvalid = true;
}

if (!isInvalid)
{
    Console.WriteLine($"{commissions:F2}");
} 
else
{
    Console.WriteLine("error");
}

