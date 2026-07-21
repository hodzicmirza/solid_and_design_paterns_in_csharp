namespace skyline_talent_program.SOLID.ISP.DobarPrimjer;

public class Sfera : IOblik3D
{
    public double Radius { get; set; }

    public double Povrsina()
    {
        return 4 * Math.PI * this.Radius * this.Radius;
    }

    public double Zapremina()
    {
        return (4.0 / 3.0) * this.Radius * this.Radius * this.Radius * Math.PI;
    }
}
