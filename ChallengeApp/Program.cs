using ChallengeApp;

var employee = new Employee("Mateusz", "Malinowski");
// /*
employee.AddScore(5);
employee.AddScore(4);
employee.AddScore(7);
employee.AddScore(7);
employee.AddScore(9);
// */

var statistics = employee.GetStatistics();

Console.WriteLine($"{employee.Name} {employee.Surname} average score: {statistics.Average:N2}");
Console.WriteLine($"{employee.Name} {employee.Surname} min score: {statistics.Min}");
Console.WriteLine($"{employee.Name} {employee.Surname} max score: {statistics.Max}");
