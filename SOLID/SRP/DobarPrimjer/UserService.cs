namespace skyline_talent_program.SOLID.SRP.DobarPrimjer;

public class UserService
{
    public void Registracija(User korisnik)
    {
        EmailSender emailSender = new EmailSender();
        emailSender.PosaljiEmail(korisnik.Email, "Cao svima, ja sam Mirza");
    }
}
