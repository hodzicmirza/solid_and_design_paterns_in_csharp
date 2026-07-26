namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Command;

public class RemoteControl
{
    private Light _light;

    public RemoteControl(Light light)
    {
        this._light = light;
    }

    public void PressButton(bool turnOn)
    {
        if (turnOn)
        {
            this._light.TurnOn();
        }
        else
        {
            this._light.TurnOff();
        }
    }
}
