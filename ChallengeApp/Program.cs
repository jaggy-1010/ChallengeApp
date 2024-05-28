using ChallengeApp;

var employee = new Employee("Mateusz", "Malinowski");
employee.AddScore(5);
employee.AddScore(4);
employee.AddScore(7);
employee.AddScore(7);
employee.AddScore(9);

var statistics = employee.GetStatistics();

Console.WriteLine($"Average score: {statistics.Average:N2}");
Console.WriteLine($"Min score: {statistics.Min}");
Console.WriteLine($"Max score: {statistics.Max}");
