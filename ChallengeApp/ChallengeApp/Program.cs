using ChallengeApp;

Employee worker1 = new Employee("Adam", "Kamizelich", 25);
Employee worker2 = new Employee("Daniel", "Kondzior", 39);
Employee worker3 = new Employee("Harry", "Potter", 28);

worker1.AddPoints(10);
worker1.AddPoints(10);
worker1.AddPoints(10);
worker1.AddPoints(2);
worker1.AddPoints(2);

worker2.AddPoints(1);
worker2.AddPoints(2);
worker2.AddPoints(3);
worker2.AddPoints(4);
worker2.AddPoints(4);

worker3.AddPoints(10);
worker3.AddPoints(10);
worker3.AddPoints(10);
worker3.AddPoints(10);
worker3.AddPoints(10);


//Console.WriteLine(worker1.Name + "_" + worker1.Surname + "_" + worker1.Age + "_" + worker1.Result);
//Console.WriteLine(worker2.Name + "_" + worker2.Surname + "_" + worker2.Age + "_" + worker2.Result);
//Console.WriteLine(worker3.Name + "_" + worker3.Surname + "_" + worker3.Age + "_" + worker3.Result + "\n");


if (worker1.Result > worker2.Result && worker1.Result > worker3.Result)
{
    Console.WriteLine(worker1.Name + "_" + worker1.Surname + "_" + worker1.Age + "_" + worker1.Result);
}
else if (worker2.Result > worker1.Result && worker1.Result > worker3.Result)
{
    Console.WriteLine(worker2.Name + "_" + worker2.Surname + "_" + worker2.Age + "_" + worker2.Result);
}
else
{ 
    Console.WriteLine(worker3.Name + "_" + worker3.Surname + "_" + worker3.Age + "_" + worker3.Result);
}