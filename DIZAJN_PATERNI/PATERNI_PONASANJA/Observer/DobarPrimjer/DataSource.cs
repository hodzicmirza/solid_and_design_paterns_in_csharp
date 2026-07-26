namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Observer.DobarPrimjer;

public class DataSource : Subject
{
    private List<int> _values = new List<int>();

    public List<int> GetValues() => this._values;

    public void SetValues(List<int> newValues)
    {
        this._values = newValues;
        this.NotifyObservers();
    }
}
