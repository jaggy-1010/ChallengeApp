namespace ChallengeApp;

public class Employee : IEmployee 
{
    // Grade by letters
    private const int GRADE_A = 100;
    private const int GRADE_B = 80;
    private const int GRADE_C = 60;
    private const int GRADE_D = 40;
    private const int GRADE_E = 20;

    // Average level by letters
    private const char AVERAGE_LEVEL_A = 'A';
    private const char AVERAGE_LEVEL_B = 'B';
    private const char AVERAGE_LEVEL_C = 'C';
    private const char AVERAGE_LEVEL_D = 'D';
    private const char AVERAGE_LEVEL_E = 'E';


    private List<float> scores = new List<float>();    

    public Employee (string name, string surname) 
    {
        this.Name = name;
        this.Surname = surname;
    }

    public string Name { get; private set; }
    public string Surname { get; private set; }

    public void AddScore(float score)
    {
        if (score >= 0 && score <= 100)
        {
            this.scores.Add(score);
        }
        else
        {
            throw new Exception("Acceptable scores from 0 to 100.");
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
                throw new Exception("String is not float");
            }
        }
        else
        {
            throw new Exception("Programm error! Please call service!");
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
        float result = score;

        switch(score)
        {
            case 'A':
            case 'a':
                this.AddScore(GRADE_A);
                break;
            case 'B':
            case 'b':
                this.AddScore(GRADE_B);
                break;
            case 'C':
            case 'c':
                this.AddScore(GRADE_C);
                break;
            case 'D':
            case 'd':
                this.AddScore(GRADE_D);
                break;
            case 'E':
            case 'e':
                this.AddScore(GRADE_E);
                break;
            default:
                throw new Exception("Wrong input value, try again!");
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
                case var average when average >= GRADE_B:
                    statistics.AverageLetter = AVERAGE_LEVEL_A;
                    break;
                case var average when average >= GRADE_C:
                    statistics.AverageLetter = AVERAGE_LEVEL_B;
                    break;
                case var average when average >= GRADE_D:
                    statistics.AverageLetter = AVERAGE_LEVEL_C;
                    break;
                case var average when average >= GRADE_E:
                    statistics.AverageLetter = AVERAGE_LEVEL_D;
                    break;
                default:
                    statistics.AverageLetter = AVERAGE_LEVEL_E;
                    break;
            }
        }
        else
        {   
            statistics.Min = 0;
            statistics.Max = 0;
            statistics.AverageLetter = AVERAGE_LEVEL_E;
        }
        return statistics;
    }

    public bool HasScore()
    {
        if (scores.Count != 0)
	    {
		    return true;
	    }
	    else
	    {
		    return false;
	    }
    }
}
