using ChallengeApp;

var employee = new Employee("Mateusz", "Malinowski");
// /*
employee.AddScore("Zygmunt");
employee.AddScore("40000");
employee.AddScore(2000);
employee.AddScore(20L);
employee.AddScore(79UL);
employee.AddScore(99M);
employee.AddScore(9);
// */

var statistics = employee.GetStatistics();

Console.WriteLine($"{employee.Name} {employee.Surname} average score: {statistics.Average:N2}");
Console.WriteLine($"{employee.Name} {employee.Surname} min score: {statistics.Min}");
Console.WriteLine($"{employee.Name} {employee.Surname} max score: {statistics.Max}");
