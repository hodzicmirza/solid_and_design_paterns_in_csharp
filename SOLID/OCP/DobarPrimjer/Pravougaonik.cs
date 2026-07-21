namespace skyline_talent_program.SOLID.OCP.DobarPrimjer;

public class Pravougaonik : Oblik
{
    public double Duzina { get; set; }
    public double Sirina { get; set; }

    public override double IzracunajPovrsinu()
    {
        return this.Duzina * this.Sirina;
    }
}
