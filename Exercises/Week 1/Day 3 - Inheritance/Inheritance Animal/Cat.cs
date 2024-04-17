namespace Inheritance;

internal class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }
    public Cat(string name, int age) : base(name, age)
    {
    }
    public override void CelebrateBirthday()
    {
        if (age < 25)
        {
            age++;
        }
        else
        {
            Console.WriteLine("Cat is too old to celebrate birthday.");
        }
    }
    public override string ToString()
    {
        return base.ToString();
    }
}