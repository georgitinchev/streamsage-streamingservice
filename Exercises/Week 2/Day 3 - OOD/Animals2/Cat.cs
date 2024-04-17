namespace Animals2;

internal class Cat : Animal
{
    public Cat(string name) : base(name)
    {
        this.name = name;
    }

    public override string Speak()
    {
        return "Meow Meow!";
    }
}