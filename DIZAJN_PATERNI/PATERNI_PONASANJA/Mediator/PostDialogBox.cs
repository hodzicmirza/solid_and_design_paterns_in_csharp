namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Mediator;

public class PostDialogBox : DialogBox
{
    // fieds
    private ListBox _postsListBox;
    private TextBox _titleTextBox;
    private Button _saveButton;

    public PostDialogBox()
    {
        this._postsListBox = new ListBox(this);
        this._titleTextBox = new TextBox(this);
        this._saveButton = new Button(this);
        this._saveButton.SetButton(false);
    }

    public override void Changed(UIControl uiControl) // ovo je najbolje sa observer uraditi ove if-ove
    {
        if (uiControl == this._postsListBox)
        {
            HandlePostChanged();
        }
        else if (uiControl == this._titleTextBox)
        {
            HandleTitleChanged();
        }
    }

    public void SimulateUserInteraction()
    {
        this._postsListBox.SetSelection("Post 2");
        this._titleTextBox.SetText("");
        System.Console.WriteLine($"Title box {this._titleTextBox.GetText()}");
        System.Console.WriteLine($"Button enabled? {this._saveButton.IsEnabed()}");
    }

    private void HandlePostChanged()
    {
        this._titleTextBox.SetText(this._postsListBox.GetSelection());
        this._saveButton.SetButton(true);
    }

    private void HandleTitleChanged()
    {
        bool isTitleEmpty = this._titleTextBox.GetText() == "";
        this._saveButton.SetButton(!isTitleEmpty);
    }
}
