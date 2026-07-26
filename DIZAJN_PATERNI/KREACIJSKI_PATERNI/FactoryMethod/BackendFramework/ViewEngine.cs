namespace skyline_talent_program.DIZAJN_PATERNI.KREACIJSKI_PATERNI.FactoryMethod;

public interface ViewEngine
{
    string Render(string fileName, Dictionary<string, object> data);
}
