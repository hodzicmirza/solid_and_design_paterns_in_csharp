namespace skyline_talent_program.DIZAJN_PATERNI.KREACIJSKI_PATERNI.AbstactFactory;

public class MacUIComponentFactory : IUIComponentFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new MacCheckbox();
    }
}
