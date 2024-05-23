using ChallengeApp;

User user1 = new User("Adam","32423fddf");
User user2 = new User("Monika","32423fddf" );
User user3 = new User("Zuzia", "32423fddf");
User user4 = new User("Damian", "32423fddf");

user1.AddScore(5);
user1.AddScore(2);
user1.AddScore(1);

user2.AddScore(2);
user2.AddScore(5);
user2.AddScore(9);


user3.AddScore(11);
user3.AddScore(1);
user3.AddScore(1);

Console.WriteLine(user3.Login);
Console.WriteLine(user3.Password);
Console.WriteLine(user3.Result);
Console.WriteLine(user1.AvgResult);