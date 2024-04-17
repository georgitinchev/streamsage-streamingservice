using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an animal type:");
            Console.WriteLine("1. Dog");
            Console.WriteLine("2. Cat");
            Console.WriteLine("3. Turtle");
            int choice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the name of the animal:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the age of the animal:");
            int age = Convert.ToInt32(Console.ReadLine());

            Animal animal = null;
            switch (choice)
            {
                case 1:
                    animal = new Dog(name, age);
                    break;
                case 2:
                    animal = new Cat(name, age);
                    break;
                case 3:
                    animal = new Turtle(name, age);
                    break;
            }

            if (animal != null)
            {
                animal.CelebrateBirthday();
                Console.WriteLine(animal.ToString());
            }
            else
            {
                Console.WriteLine("Invalid animal choice.");
            }
        }
    }
}