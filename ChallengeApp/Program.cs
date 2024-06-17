using ChallengeApp;

Console.WriteLine("Welcome to an employee evaluation program");
Console.WriteLine("=========================================");
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
		    Console.WriteLine("\nThe employee has NOT been scored!");
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

Console.WriteLine($"\nStatistics of the employee {employee.Name} {employee.Surname}:" );
Console.WriteLine($"Average score: {statistics.Average:N2}");
Console.WriteLine($"Min score: {statistics.Min}");
Console.WriteLine($"Max score: {statistics.Max}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");

Console.WriteLine();
Console.WriteLine("Welcome to a boss evaluation program");
Console.WriteLine("====================================");
Console.WriteLine();
Console.WriteLine("To leave the program enter the 'q' key");
Console.WriteLine();

Supervisor supervisor = new Supervisor("John", "Black");

while (true)
{
    Console.Write("Enter the next boss evaluation: ");
    var input = Console.ReadLine();

    if (input == "q" || input == "Q")
    {
	    if (!supervisor.HasScore())
	    {
		    Console.WriteLine("\nThe boss has NOT been scored!");
	    }
        break;
    }
    try
    {
    	supervisor.AddScore(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var bossStatistics = supervisor.GetStatistics();

Console.WriteLine($"\nStatistics of the boss {supervisor.Name} {supervisor.Surname}:" );
Console.WriteLine($"Average score: {bossStatistics.Average:N2}");
Console.WriteLine($"Min score: {bossStatistics.Min}");
Console.WriteLine($"Max score: {bossStatistics.Max}");
Console.WriteLine($"Average Letter: {bossStatistics.AverageLetter}");