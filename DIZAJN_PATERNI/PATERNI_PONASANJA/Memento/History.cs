namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Memento;

public class History
{
    private List<EditorState> _states = new List<EditorState>();
    private Editor _editor; // referenca na taj editor

    public History(Editor editor)
    {
        this._editor = editor;
    }

    public void Backup()
    {
        _states.Add(this._editor.CreateState());
    }

    public void Undo()
    {
        if (_states.Count == 0)
        {
            return;
        }

        EditorState prevState = _states.Last();
        _states.Remove(prevState);

        _editor.Restore(prevState);
    }

    public void ShowHistory()
    {
        System.Console.WriteLine("\nHistory: Here's the list of mementos:");
        foreach (var state in _states)
        {
            System.Console.WriteLine(state.GetName());
        }
    }
}
