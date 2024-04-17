namespace Animals2;

abstract class Animal
{
    protected string name { get; set; }
    public Animal(string name)
    {
        this.name = name;
    }

    public virtual string Speak()
    {
        return "Hello!";
    }
    public override string ToString()
    {
        return "I am an animal named " + name;
    }
}