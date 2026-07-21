public class AutomobilPolimorfni : VoziloBazna
{
    public int brojVrata { get; set; }

    public override void Start()
    {
        System.Console.WriteLine("Auto se pokrece.");
    }

    public override void Stop()
    {
        System.Console.WriteLine("Auto se zaustavlja.");
    }
}
