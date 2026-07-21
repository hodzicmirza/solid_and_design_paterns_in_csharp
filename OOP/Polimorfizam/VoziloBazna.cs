public class VoziloBazna
{
    public string Brend { get; set; } = null!;
    public string Model { get; set; } = null!;
    public int Godina { get; set; }

    public virtual void Start()
    {
        System.Console.WriteLine("Vozilo se pokrece.");
    }

    public virtual void Stop()
    {
        System.Console.WriteLine("Vozilo se zaustavlja.");
    }
}
