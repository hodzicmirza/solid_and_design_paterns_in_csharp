namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Mediator;

public class TextBox : UIControl
{
    private string _text = "";

    public TextBox(DialogBox owner)
        : base(owner) { }

    public string GetText() => this._text;

    public void SetText(string text)
    {
        this._text = text;
        this._owner.Changed(this);
    }
}
