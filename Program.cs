// Display a welcome message before creating the animal collection.
Console.WriteLine("Hello, World!");

// Create a list that will hold the animals in the program.
List<Animal> animals = new List<Animal>();

// Add each animal with its name, age, and species.
animals.Add(new Animal { AnimalName = "Leo", Age = 3, Species = "Lion" });
animals.Add(new Animal { AnimalName = "Milo", Age = 2, Species = "Cat" });
animals.Add(new Animal { AnimalName = "Bella", Age = 5, Species = "Dog" });
animals.Add(new Animal { AnimalName = "Charlie", Age = 4, Species = "Parrot" });
animals.Add(new Animal { AnimalName = "Daisy", Age = 1, Species = "Rabbit" });
animals.Add(new Animal { AnimalName = "Max", Age = 6, Species = "Horse" });
animals.Add(new Animal { AnimalName = "Luna", Age = 2, Species = "Cat" });

// Show the animals that were created and demonstrate their behaviors.
foreach (Animal animal in animals)
{
    Console.WriteLine($"{animal.AnimalName} is a {animal.Age}-year-old {animal.Species}.");
    animal.Eat();
    animal.Sleep();
}

// Define the data and behaviors shared by every animal.
public class Animal
{
    // These properties describe the animal.
    public required string AnimalName { get; set; }
    public int Age { get; set; }
    public required string Species { get; set; }

    // Report when the animal is eating.
    public void Eat()
    {
        Console.WriteLine($"{AnimalName} is eating.");
    }

    // Report when the animal is sleeping.
    public void Sleep()
    {
        Console.WriteLine($"{AnimalName} is sleeping.");
    }
}
