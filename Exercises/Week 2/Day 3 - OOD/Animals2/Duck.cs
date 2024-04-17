namespace Animals2;

internal class Duck : Animal
{
    public Duck(string name) : base(name)
    {
        this.name = name;
    }

    public override string Speak()
    {
        return "Quack Quack!";
    }
}