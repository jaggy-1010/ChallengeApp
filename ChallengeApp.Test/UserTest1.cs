using ChallengeApp;

namespace ChallengeApp.Test;

public class UserTest1
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

        // assert
        Assert.AreEqual(0, result);
    }
}