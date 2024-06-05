using ChallengeApp;

Console.WriteLine("Welcome to the employee evaluation program");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine("To leave the program enter the 'q' key");
Console.WriteLine();

var employee = new Employee("Mateusz", "Malinowski");

while (true)
{
    Console.Write("Enter the next employee evaluation: ");
    var input = Console.ReadLine();

    if (input == "q" || input == "Q")
    {
        break;
    }
    employee.AddScore(input);
}

var statistics = employee.GetStatistics();

Console.WriteLine($"\nStatistics of employee: {employee.Name} {employee.Surname}");
Console.WriteLine($"Average score: {statistics.Average:N2}");
Console.WriteLine($"Min score: {statistics.Min}");
Console.WriteLine($"Max score: {statistics.Max}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}\n");