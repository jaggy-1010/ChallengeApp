using ChallengeApp;

Console.WriteLine("Welcome to an employee evaluation program");
Console.WriteLine("=========================================");
Console.WriteLine();
Console.WriteLine("To leave the program enter the 'q' key");
Console.WriteLine();

var employeeInFile = new EmployeeInFile("Jan", "Kowalski");
employeeInFile.ScoreAdded += EmployeeInFileScoreAdded;

void EmployeeInFileScoreAdded(object sender, EventArgs args)
{
    Console.WriteLine("new scoring added to file.");
}
employeeInFile.AddScore(88.7f);
employeeInFile.AddScore(88);
employeeInFile.AddScore(77L);
employeeInFile.AddScore(88.3);
employeeInFile.AddScore(58.7M);
employeeInFile.AddScore("24");
employeeInFile.AddScore("82,78");
employeeInFile.AddScore('A');

Console.WriteLine($"Grades scored by employee {employeeInFile.Name} {employeeInFile.Surname}:");

static void ShowThePointsScored()
{
    if (File.Exists(Param.FILE_NAME))
    {
        using (var reader = File.OpenText(Param.FILE_NAME))
        {
            var line = reader.ReadLine();

            while (line != null)
            {
                var score = float.Parse(line);
                Console.WriteLine(score);
                line = reader.ReadLine();
            }
        }
    }
}

ShowThePointsScored();

var statistics = employeeInFile.GetStatistics();
Console.WriteLine($"\nStatistics of employee {employeeInFile.Name} {employeeInFile.Surname} written to file:");
Console.WriteLine($"Average score: {statistics.Average:N2}");
Console.WriteLine($"Min score: {statistics.Min}");
Console.WriteLine($"Max score: {statistics.Max}");
Console.WriteLine($"Average Letter: {statistics.AverageLetter}");
Console.WriteLine();

var employeeInMemory = new EmployeeInMemory("Mateusz", "Malinowski");
employeeInMemory.ScoreAdded += EmployeeInMemoryScoreAdded;

void EmployeeInMemoryScoreAdded(object sender, EventArgs args)
{
    Console.WriteLine("New scoring added to memory.");
}
Console.WriteLine($"Enter the points scored by the employee {employeeInMemory.Name} {employeeInMemory.Surname}.");
Console.WriteLine("Below grades will not be remembered and will disappear when the programm stops!");
Console.WriteLine("If you don't want continue press the 'q' key.");

while (true)
{
    Console.Write("Enter the next employee evaluation: ");
    var input = Console.ReadLine();

    if (input == "q" || input == "Q")
    {
	    if (!employeeInMemory.HasScore())
	    {
		    Console.WriteLine("\nThe employee has NOT been scored!");
	    }
        break;
    }
    try
    {
    	employeeInMemory.AddScore(input);
    }
    catch(Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var checkStatistics = employeeInMemory.GetStatistics();

Console.WriteLine($"\nStatistics of the employee {employeeInMemory.Name} {employeeInMemory.Surname} used for test purposes - not written to the file:" );
Console.WriteLine($"Average score: {checkStatistics.Average:N2}");
Console.WriteLine($"Min score: {checkStatistics.Min}");
Console.WriteLine($"Max score: {checkStatistics.Max}");
Console.WriteLine($"Average Letter: {checkStatistics.AverageLetter}");