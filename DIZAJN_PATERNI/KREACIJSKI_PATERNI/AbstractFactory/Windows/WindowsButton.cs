namespace skyline_talent_program.DIZAJN_PATERNI.KREACIJSKI_PATERNI.AbstactFactory;

public class WindowsButton : IButton
{
    public void Render()
    {
        System.Console.WriteLine("Windows: render button");
    }
}
