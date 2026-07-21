namespace skyline_talent_program.SOLID.SRP.LosPrimjer;

public class EmailSender
{
    public void PosaljiEmail(string email, string poruka)
    {
        System.Console.WriteLine($"Email poslan na adresu {email} sa porukom: {poruka}");
    }
}
