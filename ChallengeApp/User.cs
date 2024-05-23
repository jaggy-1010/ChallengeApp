namespace ChallengeApp;

public class User
{
    private List<int> score = new List<int>();

    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
    }

    public User(string login)
    {
        this.Login = login;
    }

        
    public string Login { get; private set; }
    public string Password { get; private set; }
    public  int Result
    {
        get
        {
            return this.score.Sum();
        }
        
    }
    public  double AvgResult 
    {
        get
        {
            return this.score.Average();
        }
    }

    public void AddScore(int number)
    {
        this.score.Add(number);
    } 
}