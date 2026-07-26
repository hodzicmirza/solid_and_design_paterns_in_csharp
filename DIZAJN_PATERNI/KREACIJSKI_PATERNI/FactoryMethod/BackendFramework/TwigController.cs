namespace skyline_talent_program.DIZAJN_PATERNI.KREACIJSKI_PATERNI.FactoryMethod;

public class TwigController : Controller
{
    protected override ViewEngine CreateViewEngine()
    {
        return new TwigViewEngine();
    }
}
