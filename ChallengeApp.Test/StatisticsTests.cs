using ChallengeApp;

namespace ChallengeApp.Test;

public class StatisticsTests
{
    [Test]
    public void CheckPositiveScoresStatisticsWhereEmployeeIsScored()
    {
        // arrange
        Employee employee = new Employee("Stefan","Batory");
        employee.AddScore(0);
        employee.AddScore(2);
        employee.AddScore(4);

        // act
        var statistics = employee.GetStatistics();
        var result = statistics.Average;
        var result1 = statistics.Min;
        var result2 = statistics.Max;

        // assert
        Assert.AreEqual(2.0f, result);                
        Assert.AreEqual(0.0f, result1);                
        Assert.AreEqual(4.0f, result2);                
    }

    [Test]
    public void CheckScoresStatisticsWhereEmployeeIsNotScored()
    {
        // arrange
        Employee employee = new Employee("Kazimierz","Jagiellończyk");

        // act
        var statistics = employee.GetStatistics();
        var result = statistics.Average;
        var result1 = statistics.Min;
        var result2 = statistics.Max;

        // assert
        Assert.AreEqual(0.0f, result);                
        Assert.AreEqual(0.0f, result1);                
        Assert.AreEqual(0.0f, result2);                
    }

    [Test]
    public void CheckNegativeScoresStatisticsWhereEmployeeIsScored()
    {
        // arrange
        Employee employee = new Employee("Zygmunt","August");
        employee.AddScore(-3);
        employee.AddScore(-2);
        employee.AddScore(-4);

        // act
        var statistics = employee.GetStatistics();
        var result = statistics.Average;
        var result1 = statistics.Min;
        var result2 = statistics.Max;

        // assert
        Assert.AreEqual(-3.0f, result);                
        Assert.AreEqual(-4.0f, result1);                
        Assert.AreEqual(-2.0f, result2);                
    }


    [Test]
    public void CheckMixedScoresStatisticsWhereEmployeeIsScored()
    {
        // arrange
        Employee employee = new Employee("Kazimierz","Wielki");
        employee.AddScore(2);
        employee.AddScore(0);
        employee.AddScore(-2);

        // act
        var statistics = employee.GetStatistics();
        var result = statistics.Average;
        var result1 = statistics.Min;
        var result2 = statistics.Max;

        // assert
        Assert.AreEqual(0.0f, result);                
        Assert.AreEqual(-2.0f, result1);                
        Assert.AreEqual(2.0f, result2);                
    }
}