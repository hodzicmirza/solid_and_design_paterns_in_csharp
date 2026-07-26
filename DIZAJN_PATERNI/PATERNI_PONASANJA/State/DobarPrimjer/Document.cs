namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.State.DobarPrimjer;

public class Document
{
    public State State { get; set; }
    public UserRoles CurrentUserRole { get; set; }

    public Document(UserRoles currentRole)
    {
        this.State = new DraftState(this);
        this.CurrentUserRole = currentRole;
    }

    public void Publish()
    {
        this.State.Publish();
    }
}
