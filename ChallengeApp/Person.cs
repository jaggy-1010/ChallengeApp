namespace ChallengeApp;

public abstract class Person
{
    public Person(string name, string surname, string sex)
    {
        this.Name = name;
        this.Surname = surname;
        this.Sex = sex;
    }

    public string Name { get; set; }
    public string Surname { get; set; }
    public string Sex { get; set; }
}