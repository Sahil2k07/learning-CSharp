namespace OOP
{
    public class Animal
    {
        public required string AnimalName { get; set; }

        // Common method that can be used by all animals
        public void MakeSound()
        {
            Console.WriteLine($"{AnimalName} is making a sound.");
        }
    }

    public class Dog : Animal
    {
        // Property specific to Dog class
        public required string Breed { get; set; }

        // Method unique to the Dog class
        public void Bark()
        {
            Console.WriteLine($"{AnimalName} is barking.");
        }

        public static void ShowInheritance()
        {
            // Create a Dog instance
            var dog = new Dog
            {
                AnimalName = "Buddy", // Required property from Animal class
                Breed = "Golden Retriever",
            };

            // Demonstrate calling methods
            dog.MakeSound(); // Inherited from Animal class
            dog.Bark(); // Specific to Dog class

            Console.WriteLine($"Dog's name: {dog.AnimalName}, Breed: {dog.Breed}");
        }
    }
}
