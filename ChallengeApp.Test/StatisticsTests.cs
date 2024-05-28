using ChallengeApp;

namespace ChallengeApp.Test;

public class StatisticsTests
{
    [Test]
    public void CheckScoresAverageWherewmployeeScored()
    {
        // arrange
        Employee employee = new Employee("Stefan","Batory");
        employee.AddScore(0);
        employee.AddScore(2);
        employee.AddScore(4);

        // act
        var statistics = employee.GetStatistics();
        var result = statistics.Average;

        // assert
        Assert.AreEqual(2.0f, result);                
    }

    [Test]
    public void CheckScoresAverageWhereEmployeeNotScored()
    {
        // arrange
        Employee employee = new Employee("Kazimierz","Jagiellończyk");

        // act
        var statistics = employee.GetStatistics();
        var result = statistics.Average;

        // assert
        Assert.AreEqual(0.0f, result);                
    }

    [Test]
    public void CheckScoresMinWhereEmployeeScored()
    {
        // arrange
        Employee employee = new Employee("Zygmunt","August");
        employee.AddScore(0);
        employee.AddScore(2);
        employee.AddScore(4);

        // act
        var statistics = employee.GetStatistics();
        var result = statistics.Min;

        // assert
        Assert.AreEqual(0.0f, result);                
    }

    [Test]
    public void CheckScoresMinWhereEmployeeNotScored()
    {
        // arrange
        Employee employee = new Employee("Władysław","Łokietek");

        // act
        var statistics = employee.GetStatistics();
        var result = statistics.Min;

        // assert
        Assert.AreEqual(0.0f, result);                
    }

    [Test]
    public void CheckScoresMaxWhereEmployeeScored()
    {
        // arrange
        Employee employee = new Employee("Kazimierz","Wielki");
        employee.AddScore(0);
        employee.AddScore(2);
        employee.AddScore(4);

        // act
        var statistics = employee.GetStatistics();
        var result = statistics.Max;

        // assert
        Assert.AreEqual(4.0f, result);                
    }

    [Test]
    public void CheckScoresMaxWhereEmployeeNotScored()
    {
        // arrange
        Employee employee = new Employee("Władysław","Jagiełło");

        // act
        var statistics = employee.GetStatistics();
        var result = statistics.Max;

        // assert
        Assert.AreEqual(0.0f, result);                
    }
}