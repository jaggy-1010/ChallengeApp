namespace ChallengeApp;

class Employee
{

	private List<int> score = new List<int>();
	
	public Employee(string name, string surname, int age)
	{
		this.Name = name;
		this.Surname = surname;
		this.Age = age;
		this.Sum = 0;
	}

	public string Name { get; private set; }
	public string Surname { get; private set; }
	public int Age { get; private set; }

	public int Sum { get; private set; }

	public void AddScore(int number)
	{
		this.score.Add(number);
	}

	public int Result
	{
		get
		{
			return this.score.Sum();
		}
	}
}

