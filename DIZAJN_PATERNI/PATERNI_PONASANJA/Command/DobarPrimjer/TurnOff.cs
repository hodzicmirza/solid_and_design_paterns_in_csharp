namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Command.DobarPrimjer;

public class TurnOff : ICommand
{
    private Light _light;

    public TurnOff(Light light)
    {
        this._light = light;
    }

    public void Execute()
    {
        this._light.TurnOff();
    }
}
