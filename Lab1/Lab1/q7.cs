using System;

class Animal
{
    // Virtual method in base class
    public virtual void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

class Dog : Animal
{
    // Override the virtual method
    public override void Speak()
    {
        Console.WriteLine("The dog barks.");
    }
}

class Cat : Animal
{
    // Override the virtual method
    public override void Speak()
    {
        Console.WriteLine("The cat meows.");
    }
}

class Program
{
    static void Main()
    {
        // Base class reference pointing to derived class objects
        Animal animal;

        animal = new Dog();
        animal.Speak();  // Output: The dog barks.

        animal = new Cat();
        animal.Speak();  // Output: The cat meows.

        animal = new Animal();
        animal.Speak();  // Output: The animal makes a sound.
    }
}
