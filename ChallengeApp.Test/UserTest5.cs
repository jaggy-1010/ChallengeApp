using ChallengeApp;

namespace ChallengeApp.Test;

public class UserTest5
{
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

        // assert
        Assert.AreEqual(0, result);
    }
}
