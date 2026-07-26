namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Template.DobarPrimjer;

public class Camomile : Beverage
{
    public void Prepare()
    {
        Brew();
    }

    private void Brew()
    {
        System.Console.WriteLine("Brewing camomile for 3 minutes");
    }
}
