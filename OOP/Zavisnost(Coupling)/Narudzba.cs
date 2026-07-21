public class Narudzba
{
    private readonly INotifikacijaServis notifikacijaServis;

    public Narudzba(INotifikacijaServis notifikacijaServis)
    {
        this.notifikacijaServis = notifikacijaServis;
    }

    public void Naruci()
    {
        notifikacijaServis.PosaljiNotifikaciju("Narudzba uspjesno kreirana");
    }
}
