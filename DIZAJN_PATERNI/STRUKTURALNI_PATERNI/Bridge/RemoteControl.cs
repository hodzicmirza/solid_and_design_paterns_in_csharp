namespace skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Bridge;

public class RemoteControl
{
    private Device _device;

    public RemoteControl(Device device)
    {
        _device = device;
    }

    public void TurnOn()
    {
        _device.TurnOn();
    }

    public void TurnOff()
    {
        _device.TurnOff();
    }
}
