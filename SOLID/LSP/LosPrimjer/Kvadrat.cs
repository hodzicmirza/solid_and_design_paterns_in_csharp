namespace skyline_talent_program.SOLID.LSP.LosPrimjer;

public class Kvadrat : Pravougaonik
{
    public override double Sirina
    {
        get => base.Sirina;
        set => base.Sirina = base.Duzina = value;
    }
    public override double Duzina
    {
        get => base.Duzina;
        set => base.Duzina = base.Sirina = value;
    }
}
