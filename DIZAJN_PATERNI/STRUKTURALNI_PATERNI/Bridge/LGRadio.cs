namespace skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Bridge;

public class LGRadio : Device
{
    public void TurnOff()
    {
        System.Console.WriteLine("Turning LG radio off");
    }

    public void TurnOn()
    {
        System.Console.WriteLine("Turning LG radio on");
    }

    public void SetChannel(int channel)
    {
        System.Console.WriteLine("Setting LG radio channel to " + channel);
    }
}
