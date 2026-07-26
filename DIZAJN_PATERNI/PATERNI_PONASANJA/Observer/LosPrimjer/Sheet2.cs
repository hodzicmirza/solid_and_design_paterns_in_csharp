namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Observer.LosPrimjer;

public class Sheet2
{
    private int _total;

    public int GetTotal => this._total;

    public int CalculateTotal(List<int> values)
    {
        var sum = 0;
        foreach (var value in values)
        {
            sum += value;
        }

        System.Console.WriteLine("Total: " + sum);
        return sum;
    }
}
