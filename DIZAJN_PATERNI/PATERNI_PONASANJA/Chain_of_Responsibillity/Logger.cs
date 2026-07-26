namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Chain_of_Responsibillity;

public class Logger : Handler
{
    public override bool DoHandle(HttpRequest request)
    {
        System.Console.WriteLine("Logging");
        return false;
    }
}
