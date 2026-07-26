namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Observer.DobarPrimjer;

public class Sheet2 : Observer
{
    private DataSource _dataSource;
    private int _total;

    public Sheet2(DataSource dataSource)
    {
        this._dataSource = dataSource;
    }

    public int GetTotal => this._total;

    public void Update()
    {
        this._total = CalculateTotal(this._dataSource.GetValues());
    }

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
