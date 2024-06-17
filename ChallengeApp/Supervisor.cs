namespace ChallengeApp;

public class Supervisor : IEmployee 
{
    // Grade by school marks
    private const int GRADE_6 = 100;
    private const int GRADE_6_MINUS = 95;
    private const int GRADE_5_PLUS = 85;
    private const int GRADE_5 = 80;
    private const int GRADE_5_MINUS = 75;
    private const int GRADE_4_PLUS = 65;
    private const int GRADE_4 = 60;
    private const int GRADE_4_MINUS = 55;
    private const int GRADE_3_PLUS = 45;
    private const int GRADE_3 = 40;
    private const int GRADE_3_MINUS = 35;
    private const int GRADE_2_PLUS = 25;
    private const int GRADE_2 = 20;
    private const int GRADE_2_MINUS = 15;
    private const int GRADE_1_PLUS = 5;
    private const int GRADE_1 = 0;

    // Average level by letters
    private const char AVERAGE_LEVEL_A = 'A';
    private const char AVERAGE_LEVEL_B = 'B';
    private const char AVERAGE_LEVEL_C = 'C';
    private const char AVERAGE_LEVEL_D = 'D';
    private const char AVERAGE_LEVEL_E = 'E';


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
                    result = GRADE_6;
                    this.AddScore(result);
                    break;
                case "-6":
                case "6-":
                    result = GRADE_6_MINUS;
                    this.AddScore(result);
                    break;
                case "+5":
                case "5+":
                    result = GRADE_5_PLUS;
                    this.AddScore(result);
                    break;
                case "5":
                    result = GRADE_5;
                    this.AddScore(result);
                    break;
                case "-5":
                case "5-":
                    result = GRADE_5_MINUS;
                    this.AddScore(result);
                    break;
                case "+4":
                case "4+":
                    result = GRADE_4_PLUS;
                    this.AddScore(result);
                    break;
                case "4":
                    result = GRADE_4;
                    this.AddScore(result);
                    break;
                case "-4":
                case "4-":
                    result = GRADE_4_MINUS;
                    this.AddScore(result);
                    break;
                case "+3":
                case "3+":
                    result = GRADE_3_PLUS;
                    this.AddScore(result);
                    break;
                case "3":
                    result = GRADE_3;
                    this.AddScore(result);
                    break;
                case "-3":
                case "3-":
                    result = GRADE_3_MINUS;
                    this.AddScore(result);
                    break;
                case "+2":
                case "2+":
                    result = GRADE_2_PLUS;
                    this.AddScore(result);
                    break;
                case "2":
                    result = GRADE_2;
                    this.AddScore(result);
                    break;
                case "-2":
                case "2-":
                    result = GRADE_2_MINUS;
                    this.AddScore(result);
                    break;
                case "+1":
                case "1+":
                    result = GRADE_1_PLUS;
                    this.AddScore(result);
                    break;
                case "1":
                    result = GRADE_1;
                    this.AddScore(result);
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
                case var average when average >= GRADE_5:
                    statistics.AverageLetter = AVERAGE_LEVEL_A;
                    break;
                case var average when average >= GRADE_4:
                    statistics.AverageLetter = AVERAGE_LEVEL_B;
                    break;
                case var average when average >= GRADE_3:
                    statistics.AverageLetter = AVERAGE_LEVEL_C;
                    break;
                case var average when average >= GRADE_2:
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
