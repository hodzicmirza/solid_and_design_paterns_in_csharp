namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.State.DobarPrimjer;

public class PublishedState : State
{
    private Document _document;

    public PublishedState(Document document)
    {
        this._document = document;
    }

    public void Publish()
    {
        // ne radi nista jer je objavljeno
    }
}
