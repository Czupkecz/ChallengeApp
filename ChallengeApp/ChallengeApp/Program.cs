// Zadanie domowe dzień 4

var name = "Marian";
bool isWoman = true;
var age = 29;

if (isWoman == true && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && isWoman == true)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age < 18 && isWoman != true)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}

