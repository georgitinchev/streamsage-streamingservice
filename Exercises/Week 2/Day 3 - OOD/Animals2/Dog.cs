namespace Animals2;

internal class Dog : Animal
{
    public Dog(string name) : base(name)
    {
        this.name = name;
    }

    public override string Speak()
    {
        return "Woof Woof!";
    }
}