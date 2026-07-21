namespace skyline_talent_program.SOLID.OCP.DobarPrimjer;

public class Krug : Oblik
{
    public double Radius { get; set; }

    public override double IzracunajPovrsinu()
    {
        return Math.PI * this.Radius * this.Radius;
    }
}
