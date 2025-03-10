public class ElectricCar : Automobile {

    public ElectricCar(string licensePlate, int seatingCap) 
    : base(licensePlate, seatingCap, true) {
        Console.WriteLine("ElectricCar constructor!");    
    }


    public override string ToString() {
        return $"Name: {this.Name} | Manufacturer: {this.Manufacturer}";
    }


}