namespace skyline_talent_program.SOLID.LSP.LosPrimjer;

public class Pravougaonik : Oblik
{
    public virtual double Duzina { get; set; }
    public virtual double Sirina { get; set; }
    public override double Povrsina => this.Duzina * this.Sirina;
}
