public class EmailSender : INotifikacijaServis
{
    public void PosaljiNotifikaciju(string poruka)
    {
        System.Console.WriteLine($"Slanje email-a: {poruka}");
    }
}
