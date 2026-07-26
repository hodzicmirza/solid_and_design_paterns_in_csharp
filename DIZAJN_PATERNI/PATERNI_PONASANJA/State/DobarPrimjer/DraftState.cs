namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.State.DobarPrimjer;

public class DraftState : State
{
    private Document _document;

    public DraftState(Document document)
    {
        this._document = document;
    }

    public void Publish()
    {
        _document.State = new ModerationState(_document);
    }
}
