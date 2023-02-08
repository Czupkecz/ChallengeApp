// Zadanie domowe dzień 4

var imie = "Marian";
bool płećKobieta = false;
var wiek = 29;

if (płećKobieta == true && wiek < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (imie == "Ewa" && płećKobieta == true)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (wiek < 18 && płećKobieta != true)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}

