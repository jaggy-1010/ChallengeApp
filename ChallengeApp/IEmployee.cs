using static ChallengeApp.EmployeeBase;

namespace ChallengeApp;

public interface IEmployee
{
    string Name { get; }
    string Surname { get; }
    Statistics GetStatistics();
    void AddScore(float score);
    void AddScore(string score);
    void AddScore(int score);
    void AddScore(long score);
    void AddScore(double score);
    void AddScore(decimal score);
    void AddScore(char score);
    bool HasScore();
    event ScoreAddedDelegate ScoreAdded;
}