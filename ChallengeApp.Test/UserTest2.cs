using ChallengeApp;

namespace ChallengeApp.Test;

public class UserTest2
{
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
}