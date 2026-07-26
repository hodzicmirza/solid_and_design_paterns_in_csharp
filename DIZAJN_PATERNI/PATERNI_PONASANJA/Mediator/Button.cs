namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Mediator;

public class Button : UIControl
{
    private bool _isEnabled;

    public Button(DialogBox owner)
        : base(owner) { }

    public bool IsEnabed() => this._isEnabled;

    public void SetButton(bool isEnabled)
    {
        this._isEnabled = isEnabled;
        this._owner.Changed(this);
    }
}
