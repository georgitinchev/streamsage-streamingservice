namespace Inheritance;

internal class Turtle : Animal
{
    public Turtle(string name) : base(name)
    {
    }
    public Turtle(string name, int age) : base(name, age)
    {
    }
    public override string ToString()
    { 
        return base.ToString();
    }
}