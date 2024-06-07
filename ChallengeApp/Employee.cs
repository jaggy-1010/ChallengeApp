namespace ChallengeApp;

public class Employee
{
    public string Name { get; private set; }
    public string Surname { get; private set; }

    private List<float> scores = new List<float>();

    public Employee (string name , string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }

    public void AddScore(float score)
    {
        if (score >= 0 && score <= 100)
        {
        this.scores.Add(score);
        }
        else
        {
            Console.WriteLine("Acceptable scores from 0 to 100.");
       }
    }
    
    public void AddScore(string score)
    {
        if (score != null)
        {
            if (float.TryParse(score, out float result))
            {
                this.AddScore(result);
            }
            else if(score.Length == 1)
            {
                char result1 = Convert.ToChar(score);
                this.AddScore(result1);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }
        else
        {
            Console.WriteLine("Błąd programu. Zawiadom autora.");
        }
    }

    public void AddScore(int score)
    {
        float result = score;
        this.AddScore(result);
    }
    
    public void AddScore(long score)
    {
        float result = score;
        this.AddScore(result);
    }

    public void AddScore(ulong score)
    {
        float result = score;
        this.AddScore(result);
    }

    public void AddScore(double score)
    {
        float result = (float)score;
        this.AddScore(result);
    }

    public void AddScore(decimal score)
    {
        float result = (float)score;
        this.AddScore(result);
    }

    public void AddScore(char score)
    {
        switch(score)
        {
            case 'A':
            case 'a':
                this.scores.Add(100);
                break;
            case 'B':
            case 'b':
                this.scores.Add(80);
                break;
            case 'C':
            case 'c':
                this.scores.Add(60);
                break;
            case 'D':
            case 'd':
                this.scores.Add(40);
                break;
            case 'E':
            case 'e':
                this.scores.Add(20);
                break;
            default:
                Console.WriteLine("Wrong input value, try again!");
                break;
        }
    }
    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Min = float.MaxValue;
        statistics.Max = float.MinValue;
        foreach (var score in this.scores)
        {
            statistics.Min = Math.Min(statistics.Min, score);
            statistics.Max = Math.Max(statistics.Max, score);
            statistics.Average += score;
        }

        if (this.scores.Count != 0 )
        {
            statistics.Average /= this.scores.Count;

            switch(statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }
        }
        else
        {   
            statistics.Min = 0;
            statistics.Max = 0;
            statistics.AverageLetter = 'E';
            string message = "Employee has not been scored.";
            Console.WriteLine(message);
        }
        return statistics;
    }
}
