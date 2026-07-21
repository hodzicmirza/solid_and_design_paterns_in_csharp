namespace skyline_talent_program.SOLID.ISP.LosPrimjer;

public class Krug : IOblik
{
    public double Radius { get; set; }

    public double Povrsina()
    {
        return Math.PI * this.Radius * this.Radius;
    }

    public double Zapremina()
    {
        throw new InvalidOperationException("Zapreminu nije moguce izracunati za 2D oblik");
    }
}
