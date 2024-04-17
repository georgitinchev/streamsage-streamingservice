namespace Inheritance;

internal class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }
    public Dog(string name, int age) : base(name, age)
    {
    }
    public override void CelebrateBirthday()
    {
        if(age < 20)
        {
            age++;
        }
        else
        {
            Console.WriteLine("Dog is too old to celebrate birthday.");
        }
    }
    public override string ToString()
    {
        return base.ToString();
    }
}