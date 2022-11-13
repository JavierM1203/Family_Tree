namespace Library;

public class Person
{
    public string name {get; private set;}
    public int age {get; private set;}
    
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public override string ToString()
    {
        return this.name;
    }
}