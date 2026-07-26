namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Command.DobarPrimjer;

public class Dim : ICommand
{
    private Light _light;

    public Dim(Light light)
    {
        this._light = light;
    }

    public void Execute()
    {
        this._light.Dim();
    }
}
