namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Template.DobarPrimjer;

public class Tea : Beverage
{
    public void Prepare()
    {
        Brew();
        AddCondiments();
    }

    private void Brew()
    {
        System.Console.WriteLine("Brewing tea for 3 minutes");
    }

    private void AddCondiments()
    {
        if (CustomerWantsCondiments())
        {
            System.Console.WriteLine("Adding lemon to the tea");
        }
    }

    private bool CustomerWantsCondiments()
    {
        System.Console.WriteLine("Would You like lemon whith your tea (y/n)");
        string input = Console.ReadLine();
        return input.ToLower() == "y";
    }
}
