namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Observer.LosPrimjer;

public class DataSource
{
    private List<int> _values = new List<int>();
    private List<object> _observers = new List<object>();

    public List<int> GetValues() => this._values;

    public void SetValues(List<int> newValues)
    {
        this._values = newValues;

        foreach (var observer in this._observers)
        {
            if (observer is Sheet2)
            {
                (observer as Sheet2).CalculateTotal(this._values);
            }
            else if (observer is BarChart)
            {
                (observer as BarChart).Render(this._values);
            }
        }
    }

    public void AddObserver(Object newObserver)
    {
        this._observers.Add(newObserver);
    }

    public void RemoveObserver(Object observerToRemove)
    {
        this._observers.Remove(observerToRemove);
    }
}
