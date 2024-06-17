namespace ChallengeApp;

public class Supervisor : IEmployee 
{
    private List<float> scores = new List<float>();    

    public Supervisor(string name, string surname) 
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
            float.TryParse(score, out float result);
            switch(score)
            {
                case "6":
                    this.AddScore(Param.GRADE_6);
                    break;
                case "-6":
                case "6-":
                    this.AddScore(Param.GRADE_6_MINUS);
                    break;
                case "+5":
                case "5+":
                    this.AddScore(Param.GRADE_5_PLUS);
                    break;
                case "5":
                    this.AddScore(Param.GRADE_5);
                    break;
                case "-5":
                case "5-":
                    this.AddScore(Param.GRADE_5_MINUS);
                    break;
                case "+4":
                case "4+":
                    this.AddScore(Param.GRADE_4_PLUS);
                    break;
                case "4":
                    this.AddScore(Param.GRADE_4);
                    break;
                case "-4":
                case "4-":
                    this.AddScore(Param.GRADE_4_MINUS);
                    break;
                case "+3":
                case "3+":
                    this.AddScore(Param.GRADE_3_PLUS);
                    break;
                case "3":
                    this.AddScore(Param.GRADE_3);
                    break;
                case "-3":
                case "3-":
                    this.AddScore(Param.GRADE_3_MINUS);
                    break;
                case "+2":
                case "2+":
                    this.AddScore(Param.GRADE_2_PLUS);
                    break;
                case "2":
                    this.AddScore(Param.GRADE_2);
                    break;
                case "-2":
                case "2-":
                    this.AddScore(Param.GRADE_2_MINUS);
                    break;
                case "+1":
                case "1+":
                    this.AddScore(Param.GRADE_1_PLUS);
                    break;
                case "1":
                    this.AddScore(Param.GRADE_1);
                    break;
                default:
                    throw new Exception("Wrong input value, try again!");
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
                case var average when average >= Param.GRADE_5:
                    statistics.AverageLetter = Param.AVERAGE_LEVEL_A;
                    break;
                case var average when average >= Param.GRADE_4:
                    statistics.AverageLetter = Param.AVERAGE_LEVEL_B;
                    break;
                case var average when average >= Param.GRADE_3:
                    statistics.AverageLetter = Param.AVERAGE_LEVEL_C;
                    break;
                case var average when average >= Param.GRADE_2:
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