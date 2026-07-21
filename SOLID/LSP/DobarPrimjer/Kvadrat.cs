namespace skyline_talent_program.SOLID.LSP.DobarPrimjer;

public class Kvadrat : Oblik
{
    public double DuzinaStranice { get; set; }

    public override double Povrsina => this.DuzinaStranice * this.DuzinaStranice;
}
