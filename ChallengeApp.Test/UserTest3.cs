using ChallengeApp;

namespace ChallengeApp.Test;

public class UserTest3
{
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
}
