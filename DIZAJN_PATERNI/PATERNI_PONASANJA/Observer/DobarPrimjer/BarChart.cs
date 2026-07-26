namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Observer.DobarPrimjer;

public class BarChart : Observer
{
    private DataSource _dataSource;

    public BarChart(DataSource dataSource)
    {
        this._dataSource = dataSource;
    }

    public void Update()
    {
        System.Console.WriteLine("Rendering Bar Chart");
    }
}
