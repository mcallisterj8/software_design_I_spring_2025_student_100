
Airplane plane = new Airplane("Bucky", 10000, 0);

// Console.WriteLine($"\nName: {plane.GetName()}\n");
Console.WriteLine($"\nName: {plane.Name}\n");

// plane.SetName("Bob");
plane.Name = "Bob";

// Console.WriteLine($"\nName: {plane.GetName()}\n");
Console.WriteLine($"\nName: {plane.Name}\n");

Console.WriteLine($"{plane.Name} fuel level: {plane.FuelLevel}");

decimal newFuelAmount = plane.Refuel(80);

Console.WriteLine($"New fuel amount: {newFuelAmount}");



