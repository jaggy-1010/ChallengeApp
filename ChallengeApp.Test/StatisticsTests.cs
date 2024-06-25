using ChallengeApp;

namespace ChallengeApp.Test;

public class StatisticsTests
{
    [Test]
    public void CheckScoresStatisticsWhereEmployeeIsScored()
    {
        // arrange
        EmployeeInMemory employee = new EmployeeInMemory("Stefan","Batory");
        employee.AddScore("100");
        employee.AddScore("25");
        employee.AddScore("40");
        employee.AddScore("c");
        employee.AddScore("A");
        employee.AddScore("nowak");
        employee.AddScore("124");
        employee.AddScore("G");

        // act
        var statistics = employee.GetStatistics();
        var resultAvg = Math.Round(statistics.Average, 2);
        var resultMin = statistics.Min;
        var resultMax = statistics.Max;
        var resultAvgL = statistics.AverageLetter;

        // assert
        Assert.AreEqual(Math.Round(65.00, 2), resultAvg);                
        Assert.AreEqual(25.0, resultMin);                
        Assert.AreEqual(100.0, resultMax);                
        Assert.AreEqual('B', resultAvgL);                
    }

    [Test]
    public void CheckScoresStatisticsWhereEmployeeIsNotScored()
    {
        // arrange
        EmployeeInMemory employee = new EmployeeInMemory("Kazimierz","Jagiellończyk");

        // act
        var statistics = employee.GetStatistics();
        var resultAvg = Math.Round(statistics.Average, 2);
        var resultMin = statistics.Min;
        var resultMax = statistics.Max;

        // assert
        Assert.AreEqual(Math.Round(0.0, 2), resultAvg);                
        Assert.AreEqual(0.0, resultMin);                
        Assert.AreEqual(0.0, resultMax);                
    }

}

