using ChallengeApp;

namespace ChallengeApp.Test;

public class UserTest4
{
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
}
