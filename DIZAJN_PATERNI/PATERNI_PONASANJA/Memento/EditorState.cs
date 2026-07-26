namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Memento;

public class EditorState
{
    private readonly string _title;
    private readonly string _content;

    // State metadata
    private readonly DateTime _stateCreatedAt;

    public EditorState(string title, string content)
    {
        this._title = title;
        this._content = content;
        this._stateCreatedAt = DateTime.Now;
    }

    public string GetTitle() => this._title;

    public string GetContent() => this._content;

    public DateTime GetCreatedAt() => this._stateCreatedAt;

    public string GetName() => $"{_stateCreatedAt}/ {_title}";
}
