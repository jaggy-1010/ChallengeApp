using ChallengeApp;

namespace ChallengeApp.Test;

public class StatisticsTests
{
    [Test]
    public void CheckScoresStatisticsWhereEmployeeIsScored()
    {
        // arrange
        Employee employee = new Employee("Stefan","Batory");
        employee.AddScore(1);
        employee.AddScore(2);
        employee.AddScore(4);

        // act
        var statistics = employee.GetStatistics();
        var resultAvg = Math.Round(statistics.Average, 2);
        var resultMin = statistics.Min;
        var resultMax = statistics.Max;

        // assert
        Assert.AreEqual(Math.Round(2.33f, 2), resultAvg);                
        Assert.AreEqual(1.0f, resultMin);                
        Assert.AreEqual(4.0f, resultMax);                
    }

    [Test]
    public void CheckScoresStatisticsWhereEmployeeIsNotScored()
    {
        // arrange
        Employee employee = new Employee("Kazimierz","Jagiellończyk");

        // act
        var statistics = employee.GetStatistics();
        var resultAvg = Math.Round(statistics.Average, 2);
        var resultMin = statistics.Min;
        var resultMax = statistics.Max;

        // assert
        Assert.AreEqual(Math.Round(0.0f, 2), resultAvg);                
        Assert.AreEqual(0.0f, resultMin);                
        Assert.AreEqual(0.0f, resultMax);                
    }
}

