using ChallengeApp;

Console.WriteLine("Welcome to the employee evaluation program");
Console.WriteLine("==========================================");
Console.WriteLine();
Console.WriteLine("To leave the program enter the 'q' key");
Console.WriteLine();

Employee employee = new Employee("Mateusz", "Malinowski");

while (true)
{
    Console.Write("Enter the next employee evaluation: ");
    var input = Console.ReadLine();

    if (input == "q" || input == "Q")
    {
	    if (!employee.HasScore())
	    {
		    Console.WriteLine("\nEmployee has NOT been scored!");
	    }
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
}

var statistics = employee.GetStatistics();

Console.WriteLine($"\nStatistics of employee: {employee.Name} {employee.Surname} [{employee.Sex}]");
Console.WriteLine($"Average score: {statistics.Average:N2}");
Console.WriteLine($"Min score: {statistics.Min}");
Console.WriteLine($"Max score: {statistics.Max}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
