namespace ChallengeApp;

public class EmployeeInMemory : EmployeeBase // : IEmployee
{
    private List<float> scores = new List<float>();    

    public EmployeeInMemory (string name, string surname) : base(name, surname)
    {
    }

    public override void AddScore(float score)
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
    
    public override void AddScore(string score)
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

    public override void AddScore(int score)
    {
        float result = score;
        this.AddScore(result);
    }
    
    public override void AddScore(long score)
    {
        float result = score;
        this.AddScore(result);
    }

    public override void AddScore(double score)
    {
        float result = (float)score;
        this.AddScore(result);
    }

    public override void AddScore(decimal score)
    {
        float result = (float)score;
        this.AddScore(result);
    }

    public override void AddScore(char score)
    {
        switch(score)
        {
            case 'A':
            case 'a':
                this.AddScore(Param.GRADE_A);
                break;
            case 'B':
            case 'b':
                this.AddScore(Param.GRADE_B);
                break;
            case 'C':
            case 'c':
                this.AddScore(Param.GRADE_C);
                break;
            case 'D':
            case 'd':
                this.AddScore(Param.GRADE_D);
                break;
            case 'E':
            case 'e':
                this.AddScore(Param.GRADE_E);
                break;
            default:
                throw new Exception("Wrong input value, try again!");
        }
    }

    public override Statistics GetStatistics()
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
                case var average when average >= Param.GRADE_B:
                    statistics.AverageLetter = Param.AVERAGE_LEVEL_A;
                    break;
                case var average when average >= Param.GRADE_C:
                    statistics.AverageLetter = Param.AVERAGE_LEVEL_B;
                    break;
                case var average when average >= Param.GRADE_D:
                    statistics.AverageLetter = Param.AVERAGE_LEVEL_C;
                    break;
                case var average when average >= Param.GRADE_E:
                    statistics.AverageLetter = Param.AVERAGE_LEVEL_D;
                    break;
                default:
                    statistics.AverageLetter = Param.AVERAGE_LEVEL_E;
                    break;
            }
        }
        else
        {   
            statistics.Min = 0;
            statistics.Max = 0;
            statistics.AverageLetter = Param.AVERAGE_LEVEL_E;
        }

        return statistics;
    }

    public override bool HasScore()
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