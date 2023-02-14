//Napisz program w C#, który znajdzie maksymalną liczbę spośród trzech podanych liczb
Console.WriteLine("Sprawdźmy, która z podanych 3 liczb jest największa" + "\n" + "Podaj pierwszą liczbę i naciśnij ENTER");

string number1 = Console.ReadLine();

Console.WriteLine("Teraz podaj drugą liczbę i naciśnij ENTER");

string number2 = Console.ReadLine();

Console.WriteLine("I ostatnią -> ENTER");

string number3 = Console.ReadLine();

int number1AsInteger = int.Parse(number1);
int number2AsInteger = int.Parse(number2);
int number3AsInteger = int.Parse(number3);

if (number1AsInteger > number2AsInteger && number1AsInteger > number3AsInteger)
{
    Console.WriteLine("\n Największa liczba to:" + number1);
}
else if (number2AsInteger > number1AsInteger && number2AsInteger > number3AsInteger)
{
    Console.WriteLine("\n Największa liczba to:" + number2);
}
else
{
    Console.WriteLine("\n Największa liczba to: " + number3);
}