using ChallengeApp;

Console.WriteLine("Welcome to the employee evaluation program");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine("To leave the program enter the 'q' key");
Console.WriteLine();

Employee employee = new Employee("Mateusz", "Malinowski");

int idx = 0;

while (true)
{
    Console.Write("Enter the next employee evaluation: ");
    var input = Console.ReadLine();

    if (idx == 0 && (input == "q" || input == "Q"))
    {
        Console.WriteLine("\nEmployee has NOT been scored!");
        break;
    }
    else if (input == "q" || input == "Q")
    {
        break;
    }
    try
    {
    employee.AddScore(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
    idx += 1;
}

var statistics = employee.GetStatistics();

Console.WriteLine($"\nStatistics of employee: {employee.Name} {employee.Surname}");
Console.WriteLine($"Average score: {statistics.Average:N2}");
Console.WriteLine($"Min score: {statistics.Min}");
Console.WriteLine($"Max score: {statistics.Max}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
