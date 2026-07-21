public class Vozilo
{
    public string Brend { get; set; } = null!;
    public string Model { get; set; } = null!;
    public int Godina { get; set; }

    public void Start()
    {
        System.Console.WriteLine("Vozilo se pokrece");
    }

    public void Stop()
    {
        System.Console.WriteLine("Vozilo se zaustavlja");
    }
}
