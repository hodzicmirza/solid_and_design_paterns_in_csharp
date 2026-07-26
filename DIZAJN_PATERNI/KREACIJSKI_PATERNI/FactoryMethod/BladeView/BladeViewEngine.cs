namespace skyline_talent_program.DIZAJN_PATERNI.KREACIJSKI_PATERNI.FactoryMethod;

public class BladeViewEngine : ViewEngine
{
    public string Render(string fileName, Dictionary<string, object> data)
    {
        return "View rendered from " + fileName + " by Blade";
    }
}
