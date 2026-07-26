namespace skyline_talent_program;

public class Payment
{
    private readonly string _name;
    private readonly string _cardNumber;
    private readonly float _amount;

    public Payment(string name, string cardNumber, float amount)
    {
        _name = name;
        _cardNumber = cardNumber;
        _amount = amount;
    }

    public void Pay()
    {
        System.Console.WriteLine("Charging card with name " + _name);
    }
}
