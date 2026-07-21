namespace skyline_talent_program.SOLID.DIP.LosPrimjer;

public class Automobil
{
    private Motor motor;

    public Automobil()
    {
        this.motor = new Motor();
    }

    public void PokreniAutomobil()
    {
        motor.Start();
        System.Console.WriteLine("Automobil pokrenut.");
    }
}
