public class SMSSender : INotifikacijaServis
{
    public void PosaljiNotifikaciju(string poruka)
    {
        System.Console.WriteLine($"Slanje sms-om: {poruka}");
    }
}
