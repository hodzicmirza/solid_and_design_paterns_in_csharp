namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Chain_of_Responsibillity;

public class Authenticator : Handler
{
    public override bool DoHandle(HttpRequest request)
    {
        System.Console.WriteLine("Authenticating");
        var username = request.GetUsername();
        var password = request.GetPassword();
        return !(username == "mirza" && password == "praksa");
    }
}
