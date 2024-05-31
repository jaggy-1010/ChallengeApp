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
var statistics1 = employee.GetStatisticsWithForEach();
var statistics2 = employee.GetStatisticsWithFor();
var statistics3 = employee.GetStatisticsWithDowhile();
var statistics4 = employee.GetStatisticsWithWhile();


Console.WriteLine("\nUsing GetStatistics()");
Console.WriteLine($"{employee.Name} {employee.Surname} average score: {statistics.Average:N2}");
Console.WriteLine($"{employee.Name} {employee.Surname} min score: {statistics.Min}");
Console.WriteLine($"{employee.Name} {employee.Surname} max score: {statistics.Max} \n");

Console.WriteLine("Using GetStatisticsWithForEach()");
Console.WriteLine($"{employee.Name} {employee.Surname} average score: {statistics1.Average:N2}");
Console.WriteLine($"{employee.Name} {employee.Surname} min score: {statistics1.Min}");
Console.WriteLine($"{employee.Name} {employee.Surname} max score: {statistics1.Max} \n");

Console.WriteLine("Using GetStatisticswithFor()");
Console.WriteLine($"{employee.Name} {employee.Surname} average score: {statistics2.Average:N2}");
Console.WriteLine($"{employee.Name} {employee.Surname} min score: {statistics2.Min}");
Console.WriteLine($"{employee.Name} {employee.Surname} max score: {statistics2.Max} \n");

Console.WriteLine("Using GetStatisticswithDoWhile()");
Console.WriteLine($"{employee.Name} {employee.Surname} average score: {statistics3.Average:N2}");
Console.WriteLine($"{employee.Name} {employee.Surname} min score: {statistics3.Min}");
Console.WriteLine($"{employee.Name} {employee.Surname} max score: {statistics3.Max} \n");

Console.WriteLine("Using GetStatisticswithWhile()");
Console.WriteLine($"{employee.Name} {employee.Surname} average score: {statistics4.Average:N2}");
Console.WriteLine($"{employee.Name} {employee.Surname} min score: {statistics4.Min}");
Console.WriteLine($"{employee.Name} {employee.Surname} max score: {statistics4.Max} \n");