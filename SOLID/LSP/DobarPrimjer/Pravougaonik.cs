namespace skyline_talent_program.SOLID.LSP.DobarPrimjer;

public class Pravougaonik : Oblik
{
    public virtual double Duzina { get; set; }
    public virtual double Sirina { get; set; }
    public override double Povrsina => this.Duzina * this.Sirina;
}
