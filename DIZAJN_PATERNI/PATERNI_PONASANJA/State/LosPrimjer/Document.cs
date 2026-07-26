namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.State.LosPrimjer;

public class Document
{
    public DocumentStates State { get; set; }
    public UserRoles CurrentUserRole { get; set; }

    public void Publish()
    {
        if (this.State == DocumentStates.Draft)
        {
            this.State = DocumentStates.Moderation;
        }
        else if (this.State == DocumentStates.Moderation)
        {
            if (this.CurrentUserRole == UserRoles.Admin)
            {
                this.State = DocumentStates.Published;
            }
        }
        else if (State == DocumentStates.Published)
        {
            // do nothing as it's published
        }
    }
}
