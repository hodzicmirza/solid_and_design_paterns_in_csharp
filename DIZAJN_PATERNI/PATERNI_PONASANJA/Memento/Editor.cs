namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Memento;

public class Editor
{
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;

    public EditorState CreateState()
    {
        return new EditorState(this.Title, this.Content); // ovdje zapravo vracamo kopiju ovu koja je Editor state i pozivamo je u backup history
    }

    public void Restore(EditorState editorState)
    {
        this.Title = editorState.GetTitle();
        this.Content = editorState.GetContent();
    }
}
