namespace skyline_talent_program.DIZAJN_PATERNI.KREACIJSKI_PATERNI.AbstactFactory;

public interface IUIComponentFactory
{
    IButton CreateButton();
    ICheckbox CreateCheckbox();
}
