using ChallengeApp;
namespace ChallengeApp.Test;

public class EmployeeTests
{
    [Test]
    public void CheckEmployeeName()
    {
        // arrange
        EmployeeInMemory employee = new EmployeeInMemory("Mieszko", "Pierwszy");

        //act
        var result = employee.Name;

        //assert
        Assert.AreEqual("Mieszko", result);
    }

    [Test]
    public void CheckEmployeeSurname()
    {
        // arrange
        EmployeeInMemory employee = new EmployeeInMemory("Bolesław", "Chrobry");

        //act
        var result = employee.Surname;

        //assert
        Assert.AreEqual("Chrobry", result);
    }
}
