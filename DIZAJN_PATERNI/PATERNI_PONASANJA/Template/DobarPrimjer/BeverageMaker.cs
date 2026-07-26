namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Template.DobarPrimjer;

public class BeverageMaker
{
    private Beverage _beverage;

    public BeverageMaker(Beverage beverage)
    {
        this._beverage = beverage;
    }

    public void SetBeverage(Beverage newBeverage)
    {
        this._beverage = newBeverage;
    }

    public void MakeBeverage()
    {
        BoilWater();
        PourWaterIntoCup();
        this._beverage.Prepare();
    }

    private void BoilWater()
    {
        System.Console.WriteLine("Boiling water");
    }

    private void PourWaterIntoCup()
    {
        System.Console.WriteLine("Pouring water into cup");
    }
}
