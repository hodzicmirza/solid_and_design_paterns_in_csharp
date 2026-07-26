namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Chain_of_Responsibillity;

public class WebServer
{
    private Handler _handler;

    public WebServer(Handler handler)
    {
        _handler = handler;
    }

    public void Handle(HttpRequest request)
    {
        _handler.Handle(request);
    }
}
