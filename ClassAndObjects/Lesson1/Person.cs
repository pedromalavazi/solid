namespace Lesson1;

public class Person
{
    public Person() { }

    public Person(string name, int age, string gender)
    {
        this.name = name;
        this.age = age;
        this.gender = gender;
    }

    public string? name { get; set; }
    public int age { get; set; }
    public string? gender { get; set; }

    public void Identify()
    {
        Console.WriteLine($"Olá, meu nome é {name}, tenho {age} anos e sou do sexo {gender}");
    }
}
