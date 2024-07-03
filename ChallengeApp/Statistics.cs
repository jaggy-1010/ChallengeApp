namespace ChallengeApp;

public class Statistics
{
    private float min;
    private float max; 
    
    public float Min 
    {
        get
        {
            if (this.Count == 0)
            {
                return 0;
            }
            else
            {
                return min;
            }
        }
        set
        {
            min = value;
        }
    }

    public float Max 
    {
        get
        {
            if (this.Count == 0)
            {
                return 0;
            }
            else
            {
                return max;
            }
        }
        set
        {
            max = value;
        }
    }
    public float Sum { get; set; }
    public int Count { get; set; }
    public float Average
    {
        get
        {
            if (this.Count != 0)
            {
                return this.Sum / this.Count;
            }
            else
            {
                return 0;
            }
        }
    }
    public char AverageLetter
    {
        get
        {
            switch(this.Average)
            {
                case var average when average >= Param.GRADE_B:
                    return Param.AVERAGE_LEVEL_A;
                case var average when average >= Param.GRADE_C:
                    return Param.AVERAGE_LEVEL_B;
                case var average when average >= Param.GRADE_D:
                    return Param.AVERAGE_LEVEL_C;
                case var average when average >= Param.GRADE_E:
                    return Param.AVERAGE_LEVEL_D;
                default:
                    return Param.AVERAGE_LEVEL_E;
            }
        }
    }
    public Statistics()
    {
        this.Count = 0;
        this.Sum = 0;
        this.Min = float.MaxValue;
        this.Max = float.MinValue;
    }

    public void AddScore(float score)
    {
        this.Count++;
        this.Sum += score;
        this.Min = Math.Min(score, this.Min);
        this.Max = Math.Max(score, this.Max);
    }
}
