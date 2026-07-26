namespace skyline_talent_program.DIZAJN_PATERNI.KREACIJSKI_PATERNI.Singleton;

public class Test
{
    public void Run()
    {
        var settings = AppSettings.GetInstance();
        System.Console.WriteLine(settings.Get("app_creator")); // set app_creator in Main and it will return same value when this Run() method is called
    }
}
