namespace skyline_talent_program.DIZAJN_PATERNI.KREACIJSKI_PATERNI.FactoryMethod;

public abstract class Controller
{
    public void Render(string fileName, Dictionary<string, object> data)
    {
        var viewEngine = CreateViewEngine();
        var html = viewEngine.Render(fileName, data);
        System.Console.WriteLine(html);
    }

    protected virtual ViewEngine CreateViewEngine()
    {
        return new BladeViewEngine();
    }

    // Note that we could also implement our template method as an abstract method, and so providing no default view engine, and forcing the developer to select one.
    // protected abstract ViewEngine CreateViewEngine();
}
