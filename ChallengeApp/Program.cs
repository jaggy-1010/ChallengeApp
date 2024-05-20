using ChallengeApp;

Employee emp1 = new Employee("Jan", "Malinowski", 28);
Employee emp2 = new Employee("Agata", "Kowalska", 27);
Employee emp3 = new Employee("Maurycy", "Odyniec", 55);

List<Employee> employees = new List<Employee>();

employees.Add(emp1);
employees.Add(emp2);
employees.Add(emp3);

emp1.AddScore(7);
emp1.AddScore(7);
emp1.AddScore(8);
emp1.AddScore(6);
emp1.AddScore(8);

emp2.AddScore(5);
emp2.AddScore(8);
emp2.AddScore(8);
emp2.AddScore(8);
emp2.AddScore(9);

emp3.AddScore(6);
emp3.AddScore(7);
emp3.AddScore(8);
emp3.AddScore(6);
emp3.AddScore(7);

var result1 = emp1.Result;
var result2 = emp2.Result;
var result3 = emp3.Result;

List<int> sums = new List<int>();

sums.Add(result1);
sums.Add(result2);
sums.Add(result3);

var sumsMax = sums.Max();
int winnerNumber = sums.IndexOf(sumsMax);
Console.WriteLine("Imię: " + employees[winnerNumber].Name + ", nazwisko: " + employees[winnerNumber].Surname + ", wiek: " + employees[winnerNumber].Age + ",\nzdobyte punkty: " + employees[winnerNumber].Result);
