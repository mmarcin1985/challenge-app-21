
var name = "Ewa";
var isWomen = true;
var age = 44;

if (name == "Ewa" && isWomen && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (isWomen && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else
{
    if (!isWomen && age < 18)
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
    else
    {
        Console.WriteLine("to ktoś inny");
    }
}