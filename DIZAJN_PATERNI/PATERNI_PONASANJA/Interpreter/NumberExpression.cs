namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Interpreter;

public class NumberExpression : IExpression
{
    private int _number;

    public NumberExpression(int number)
    {
        _number = number;
    }

    public NumberExpression(string number)
    {
        _number = int.Parse(number);
    }

    public int Interpret(Context context)
    {
        return _number;
    }
}
