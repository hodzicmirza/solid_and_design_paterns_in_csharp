public class HardDisk
{
    private int velicina;

    public HardDisk(int velicina)
    {
        if (velicina <= 0)
        {
            throw new ArgumentOutOfRangeException("Velicina Hard Diska mora biti pozitivna");
        }
        this.velicina = velicina;
        System.Console.WriteLine("Ubacivanje HardDisk-a");
    }
}
