namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Interpreter;

public class Interpreter
{
    private Context _context;

    public Interpreter(Context context)
    {
        _context = context;
    }

    public int Interpret(string expression)
    {
        IExpression expressionTree = BuildExpressionTree(expression);
        return expressionTree.Interpret(_context);
    }

    private IExpression BuildExpressionTree(string input)
    {
        input = "1 + 2 * 3"; // result should be 7

        // 1 + 2 * 3
        // 2 * 3 = 6
        // 1 + 6 = 7
        IExpression expressionTree = new AdditionExpression(
            new MultiplicationExpression(new NumberExpression("2"), new NumberExpression("3")),
            new NumberExpression("1")
        );

        return expressionTree;
    }
}
