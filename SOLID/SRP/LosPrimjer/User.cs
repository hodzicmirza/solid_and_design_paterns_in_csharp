namespace skyline_talent_program.SOLID.SRP.LosPrimjer;

public class User
{
    public string KorisnckoIme { get; set; } = null!;
    public string Email { get; set; } = null!;

    public void Registracija(string ime, string email)
    {
        //logika registacije
        this.KorisnckoIme = ime;
        this.Email = email;

        EmailSender emailSender = new EmailSender();
        emailSender.PosaljiEmail(this.Email, "Cao svima, ja sam Mirza");
    }
}
