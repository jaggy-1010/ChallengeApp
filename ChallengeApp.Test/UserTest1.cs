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
}