namespace ChallengeApp;

public class Employee
{
    public string Name { get; private set;}
    public string Surname {get; private set;}
    private List<float> scores = new List<float>();

    public Employee ( string name , string surname)
    {
        this.Name = name;
        this.Surname = surname;
    }

    public void AddScore(float score)
    {
        this.scores.Add(score);
    }
    
    public Statistics GetStatistics()
    {
        var statistics = new Statistics();
        statistics.Average = 0;
        statistics.Min = float.MaxValue;
        statistics.Max = float.MinValue;

        foreach(var score in this.scores)
        {
            statistics.Min = Math.Min(statistics.Min, score);
            statistics.Max = Math.Max(statistics.Max, score);
            statistics.Average += score;
        }

        statistics.Average /= this.scores.Count;

        return statistics;
    }
}
