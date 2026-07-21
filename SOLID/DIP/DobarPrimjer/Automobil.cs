namespace skyline_talent_program.SOLID.DIP.DobarPrimjer;

public class Automobil
{
    private IMotor motor;

    public Automobil(IMotor motor)
    {
        this.motor = motor;
    }

    public void PokreniAutomobil()
    {
        motor.Start();
        System.Console.WriteLine("Automobil pokrenut.");
    }
}
