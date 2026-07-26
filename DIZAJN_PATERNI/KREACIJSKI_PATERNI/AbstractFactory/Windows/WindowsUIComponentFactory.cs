namespace skyline_talent_program.DIZAJN_PATERNI.KREACIJSKI_PATERNI.AbstactFactory;

public class WindowsUIComponentFactory : IUIComponentFactory
{
    public IButton CreateButton()
    {
        return new WindowsButton();
    }

    public ICheckbox CreateCheckbox()
    {
        return new WindowsCheckbox();
    }
}
