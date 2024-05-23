using ChallengeApp;

namespace ChallengeApp.Test;

public class UserTests
{
    [Test]
    public void UserCollectsPositiveScores_ReturnedSumIsPositive()
    {
       // arrange
       var user = new User("Adam", "agagaga6374586");
       user.AddScore(9);
       user.AddScore(5);
       user.AddScore(8);

       // act
       var result = user.Result;

       // assert 
       Assert.AreEqual(22, result);
    }

    [Test]
        public void UserCollectsMixedScores_ReturnedSumIsPositive()
    {
        // arrange
        var user = new User("Zofia", "8484848920skd");
        user.AddScore(10);
        user.AddScore(2);
        user.AddScore(-7);
        user.AddScore(-4);

        // act
        var result = user.Result;

        // assert
        Assert.AreEqual(1, result);
    }
    
    [Test]
      public void UserCollectsMixedScores_ReturnedSumIsZero()
    {
        // arrange
        var user = new User("Konrad", "78567ab%4");
        user.AddScore(6);
        user.AddScore(-6);
        user.AddScore(5);
        user.AddScore(-5);

        // act
        var result = user.Result;

        // assert
        Assert.AreEqual(0, result);
    }  

    [Test]
    public void UserCollectsMixedScores_ReturnedSumIsNegative()
    {
        // arrange
        var user = new User("Marzena", "a476$23B");
        user.AddScore(7);
        user.AddScore(7);
        user.AddScore(-7);
        user.AddScore(-8);
        // act
        var result = user.Result;

        // assert
        Assert.AreEqual(-1, result);
    }

    [Test]
    public void UserCollectsZeroesScores_ReturnedSumIsZero()
    {
        // arrange
        var user = new User("Tomasz", "675645&23q");
        user.AddScore(0);
        user.AddScore(0);
        user.AddScore(0);
        user.AddScore(0);
        // act
        var result = user.Result;
        Console.WriteLine(result);


        // assert
        Assert.AreEqual(0, result);
    }
    [Test]
    public void CheckUserAveragePoints()
    {
        //arrange
        var user = new User("Piotr","23456%44");
        user.AddScore(-1);
        user.AddScore(7);
        user.AddScore(8);

        //act
        var result = user.AvgResult;

        // assert
        Assert.AreEqual(4.666666666666667d, result);
    }   

    [Test]
    public void CheckUserLogin()
    {
        // arrange
        User user = new User("Jan","6738765876aa");

        // act
        var result = user.Login;

        // assert
        Assert.AreEqual("Jan", result);
    }

    [Test]
    public void CheckUserPassword()
    {
            // arrange
        User user = new User("Maria","rhtTw%23");

        // act
        var result = user.Password;

        // assert
        Assert.AreEqual("rhtTw%23", result);
    }


    // [Test]
    //  public void CheckIfNewStringsAreNotEqual()
    //  {
    //     // arrange
    //      var user1 = GetUser("Adam");
    //      var user2 = GetUser("Adam");

    //     // act

    //     // assert
    //      Assert.AreNotEqual(user1, user2);

    //  }

    //  private User GetUser(string name)
    //  {
    //      return new User(name);
    //  }
}