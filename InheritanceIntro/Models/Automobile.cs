public class Automobile : Vehicle {
    public string LicensePlate { get; set; }
    public int SeatingCapacity { get; set; }
    public bool IsElectric { get; set; }

    
    public Automobile(string licensePlate, int seatingCap, bool isElectric) {
        Console.WriteLine("Automobile constructor!");
        this.LicensePlate = licensePlate;
        this.SeatingCapacity = seatingCap;
        this.IsElectric = isElectric;
    }

    public override void Drive() {
        Console.WriteLine("Automobile is driving!");
    }

    public override void Stop() {    
        Console.WriteLine("Automobile has parked.");
    }

}