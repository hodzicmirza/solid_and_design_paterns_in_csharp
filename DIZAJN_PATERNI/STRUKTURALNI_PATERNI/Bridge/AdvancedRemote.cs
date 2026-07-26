namespace skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Bridge;

public class AdvancedRemote : RemoteControl
{
    public AdvancedRemote(Device device)
        : base(device) { }

    public void SetChannel(int channel)
    {
        System.Console.WriteLine("Setting channel to " + channel);
    }
}
