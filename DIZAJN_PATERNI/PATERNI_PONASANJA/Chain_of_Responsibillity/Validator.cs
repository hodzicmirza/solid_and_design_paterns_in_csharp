namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Chain_of_Responsibillity;

public class Validator : Handler
{
    public override bool DoHandle(HttpRequest request)
    {
        System.Console.WriteLine("Validating");
        var username = request.GetUsername();
        var password = request.GetPassword();

        request.ValidatedUsername = username.Trim();
        request.ValidatedPassword = password.Trim();

        return request.ValidatedUsername == "" || request.ValidatedPassword == "";
    }
}
