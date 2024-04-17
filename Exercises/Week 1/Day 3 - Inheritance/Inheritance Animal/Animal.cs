namespace Inheritance;

internal class Animal 
{
    protected string name;
    protected int age;
    public Animal(string name)
    {
        this.name = name;
        this.age = 1;
    }
    public Animal(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
    public virtual void CelebrateBirthday()
    {
        if(age < 100)
        {
            age++;
        }
        else
        {
            Console.WriteLine("Animal is too old to celebrate birthday.");
        }
    }
    public override string ToString()
    {
        return $"{name} ({age} year)";
    }
}