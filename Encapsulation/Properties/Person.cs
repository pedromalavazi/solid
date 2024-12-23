namespace Properties;

public class Person
{
    private string name;
    private string? gender;
    private int age;

    public Person(string name)
    {
        this.Name = name;
    }

    public string Name { get; }

    public string Gender
    {
        set
        {
            this.gender = value;
            Console.WriteLine(this.gender);
        }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 18)
            {
                System.Console.WriteLine("Idade precisa ser maior que 18");
            }
            else
            {
                this.age = value;
            }
        }
    }
}
