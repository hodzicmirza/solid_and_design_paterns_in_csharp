namespace skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Adapter;

// Adapter class. Rainbow is the adaptee
public class RainbowColour : Colour
{
    private Rainbow _rainbow; // "composition" -- RainbowColor is composed of, "has a", Rainbow. See RainbowAdapter for inheritance alternative.

    public RainbowColour(Rainbow rainbow)
    {
        _rainbow = rainbow;
    }

    public void Apply(Video video)
    {
        _rainbow.Setup();
        _rainbow.Update(video);
    }
}
