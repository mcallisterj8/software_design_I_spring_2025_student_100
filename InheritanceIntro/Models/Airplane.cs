public class Airplane : Vehicle {

    public Airplane() {
        Console.WriteLine("Airplane constructor!");
    }

    public override void Drive() {
        Console.WriteLine("Airplane is flying!");
    }

    public override void Stop() {
        this.DeployLandingGear();
        Console.WriteLine("Airplane is landing.");
    }

    public void DeployLandingGear() {
        Console.WriteLine("Deploying landing gear.");
    }

    public void ShowManufacturer(){
        base.DisplayManufacturer();
    }

}