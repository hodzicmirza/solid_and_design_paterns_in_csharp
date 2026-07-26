namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Chain_of_Responsibillity;

public abstract class Handler
{
    private Handler _nextHandler;

    public Handler setNext(Handler nextHandler)
    {
        this._nextHandler = nextHandler;
        return nextHandler;
    }

    public void Handle(HttpRequest request)
    {
        if (DoHandle(request))
        {
            return;
        }

        if (this._nextHandler != null)
        {
            this._nextHandler.Handle(request);
        }
    }

    public abstract bool DoHandle(HttpRequest request);
}
