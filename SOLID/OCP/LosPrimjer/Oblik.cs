namespace skyline_talent_program.SOLID.OCP.LosPrimjer;

public class Oblik
{
    public TipOblika Tip { get; set; }
    public double Radius { get; set; }
    public double Duzina { get; set; }
    public double Sirina { get; set; }

    public double IzracunajPovrsinu()
    {
        switch (Tip)
        {
            case TipOblika.Krug:
                return Math.PI * this.Radius * this.Radius;

            case TipOblika.Pravougaonik:
                return this.Duzina * this.Sirina;

            default:
                throw new InvalidOperationException("Ne podrzavamo oblik");
        }
    }
}
