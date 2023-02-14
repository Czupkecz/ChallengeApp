//Napisz program w C#, który sprawdzi czy liczba jest dodatnia, ujemna lub równa 0
Console.WriteLine("Sprawdźmy, czy podana liczna jest dodatnia, ujamna bądź równa 0" + "\n" + "Podaj liczbę i naciśnij ENTER");

string number1 = Console.ReadLine();

int number1AsInteger = int.Parse(number1);

if (number1AsInteger > 0)
{
    Console.WriteLine("\n Liczba " + number1 + " jest większa od 0");
}
else if (number1AsInteger == 0)
{
    Console.WriteLine("\n Liczba " + number1 + " jest równa 0");
}
else
{
    Console.WriteLine("\n Liczba " + number1 + " jest mniejsza od 0");
}