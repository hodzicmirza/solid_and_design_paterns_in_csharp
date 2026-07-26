namespace skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Facade;

public class OrderRequest
{
    public string Name { get; } = "Mirza";
    public string CardNumber { get; } = "0000";
    public float Amount { get; } = 100.99f;
    public string Address { get; } = "Bratstva i Jedinstva 71, Kakanj";

    // item ids user wants to order
    public string[] ItemIds { get; } = { "123", "423", "555", "989" };
}
