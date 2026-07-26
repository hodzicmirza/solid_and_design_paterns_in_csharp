namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Command.DobarPrimjer;

public class TurnOn : ICommand
{
    private Light _light;

    public TurnOn(Light light)
    {
        this._light = light;
    }

    public void Execute()
    {
        this._light.TurnOn();
    }
}
