/*
This syntax was compulsory but not now

class Program
{
    public static void Main(string[] args)
    {
        Basics1.Variables.ShowVariables();
    }
}
*/

using AsyncProgramming;
using OOP;
using TypeSystem;

// Variables variable = new Variables(); // Original

Variables variable = new();

Variables.ShowVariables();

Records.ShowRecords();

Car.ShowInterfaces();

int[] vals = [1, 2, 3, 4];
Generics.ShowGenerics<int>(vals);

// Encapsulation
Vehicle.ShowEncapsulation();

var truck = new Vehicle();
truck.SetName("truck name");

// truck.VehicleModel = "eicher"; // Not Allowed since private

Console.WriteLine(truck.GetVehicleName());

// Inheritence
Dog.ShowInheritance();

// Polymorphism
HarryPotter.ShowPolymorphism();

// Abstraction
Csharp.ShowAbstraction();

// Async Programming
ExceptionHandeling.ShowExceptionHandeling(10, 0);

//Async Await
await AsyncAwait.ShowAsyncAwait();

// MultiThreading
MultiThreading.ShowMultiThreading();
