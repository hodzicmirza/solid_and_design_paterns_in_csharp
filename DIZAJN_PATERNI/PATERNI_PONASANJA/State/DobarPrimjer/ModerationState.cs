namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.State.DobarPrimjer;

public class ModerationState : State
{
    private Document _document;

    public ModerationState(Document document)
    {
        this._document = document;
    }

    public void Publish()
    {
        if (_document.CurrentUserRole == UserRoles.Admin)
        {
            _document.State = new PublishedState(_document);
        }
    }
}
