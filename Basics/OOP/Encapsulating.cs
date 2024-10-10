namespace OOP
{
    // Encapsulation is the concept of bundling data (variables) and methods (functions) that operate on the data into a single unit called a class.
    public class Vehicle
    {
        private string? VehicleName;

        // carName getter
        public string? GetVehicleName() => VehicleName;

        // carName setter
        public void SetName(string name) => VehicleName = name;

        // CarModel with a getter and setter short hand
        private string? VehicleModel { get; set; }

        public static void ShowEncapsulation()
        {
            var car1 = new Vehicle { VehicleModel = "Muscle", VehicleName = "Challenger" };
            Console.WriteLine(car1.VehicleName);
            Console.WriteLine(car1.GetVehicleName());

            Console.WriteLine($"Car's name is {car1.VehicleName} and model is {car1.VehicleModel}");
        }
    }
}
