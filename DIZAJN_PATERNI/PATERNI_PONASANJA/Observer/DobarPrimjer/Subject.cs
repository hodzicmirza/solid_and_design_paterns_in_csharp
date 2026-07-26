namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Observer.DobarPrimjer;

public class Subject
{
    private List<Observer> _observers = new List<Observer>();

    public void AddObserver(Observer newObserver)
    {
        this._observers.Add(newObserver);
    }

    public void RemoveObserver(Observer observerToRemove)
    {
        this._observers.Remove(observerToRemove);
    }

    public void NotifyObservers()
    {
        foreach (Observer observer in this._observers)
        {
            observer.Update();
        }
    }
}
