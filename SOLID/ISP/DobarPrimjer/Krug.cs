namespace skyline_talent_program.SOLID.ISP.DobarPrimjer;

public class Krug : IOblik2D
{
    public double Radius { get; set; }

    public double Povrsina()
    {
        return Math.PI * this.Radius * this.Radius;
    }
}
