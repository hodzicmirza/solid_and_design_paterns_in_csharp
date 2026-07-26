namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Template.LosPrimjer;

public class Tea
{
    public void MakeBevrage()
    {
        BoilWater();
        PourWaterIntoCup();
        Brew();
        AddCondiments();
    }

    private void BoilWater()
    {
        System.Console.WriteLine("Boiling water");
    }

    private void PourWaterIntoCup()
    {
        System.Console.WriteLine("Pouring water into cup");
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
