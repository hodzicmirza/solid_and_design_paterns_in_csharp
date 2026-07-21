public class BankovniRacun
{
    private decimal balans;

    public BankovniRacun(decimal balans)
    {
        Deposit(balans);
    }

    public void Deposit(decimal balans)
    {
        if (balans <= 0)
        {
            throw new ArgumentException("Balans mora biti veci od 0");
        }

        this.balans += balans;
    }

    public void Withdraw(decimal iznos)
    {
        if (iznos <= 0)
        {
            throw new ArgumentException("Iznos mora biti veci od 0");
        }

        if (iznos > this.balans)
        {
            throw new ArgumentException("Iznos ne moze biti veci od balansa racuna");
        }

        this.balans -= iznos;
    }

    public decimal GetStanjeRacuna()
    {
        return this.balans;
    }
}
