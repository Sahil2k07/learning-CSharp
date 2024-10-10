using System.Globalization;

namespace TypeSystem
{
    // Intefaces contains definitions of Methods and variables
    interface IEquatable<T>
    {
        string CarType { get; set; }

        string? CarColor { get; set; }

        bool Equals(T obj);
    }

    public class Car : IEquatable<Car>
    {
        public string? Make { get; set; } // ? means that it is nullable
        public string? Model { get; set; }
        public string? Year { get; set; }

        // Implementation of IEquatable<T> interface

        // Default Values of CarType and CarColor
        public string CarType { get; set; } = "Race Car";
        public string? CarColor { get; set; } = "Red";

        public bool Equals(Car? car)
        {
            return (this.Make, this.Model, this.Year) == (car?.Make, car?.Model, car?.Year);
        }

        public static void ShowInterfaces()
        {
            // Create two car instances with the same properties
            Car car1 =
                new()
                {
                    Make = "Ford",
                    Model = "Mustang",
                    Year = "2022",
                    CarType = "Muscle Car",
                };

            Console.WriteLine(
                $"The car object also has the type {car1.CarType} and color {car1.CarColor}"
            );

            var car2 = new Car
            {
                Make = "Ford",
                Model = "Mustang",
                Year = "2022",
            };

            Car car3 =
                new()
                {
                    Make = "Toyota",
                    Model = "Corolla",
                    Year = "2021",
                };

            // Check if car1 is equal to car2 using the Equals method
            bool areEqual1 = car1.Equals(car2);
            Console.WriteLine($"car1 equals car2: {areEqual1}");

            // Check if car1 is equal to car3 using the Equals method
            bool areEqual2 = car1.Equals(car3);
            Console.WriteLine($"car1 equals car3: {areEqual2}");
        }
    }
}
