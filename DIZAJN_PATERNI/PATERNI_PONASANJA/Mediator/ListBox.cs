namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Mediator;

public class ListBox : UIControl
{
    private string _selection = "";

    public ListBox(DialogBox owner)
        : base(owner) { }

    public string GetSelection() => this._selection;

    public void SetSelection(string selection)
    {
        this._selection = selection;
        _owner.Changed(this);
    }
}
