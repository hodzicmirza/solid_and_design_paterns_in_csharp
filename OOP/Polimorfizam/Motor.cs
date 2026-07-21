public class Motor : VoziloBazna
{
    public int godinaProizvodnje { get; set; }

    public override void Start()
    {
        System.Console.WriteLine("Motor se pali.");
    }

    public override void Stop()
    {
        System.Console.WriteLine("Motor se pali.");
    }
}
