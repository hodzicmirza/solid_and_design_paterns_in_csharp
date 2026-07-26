namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Command.DobarPrimjer;

public class RemoteControl
{
    private ICommand _command;

    public RemoteControl(ICommand command)
    {
        this._command = command;
    }

    public void SetCommand(ICommand newCommand)
    {
        this._command = newCommand; // mijenjamo komandu u runtime-u
    }

    public void PressButton()
    {
        this._command.Execute();
    }
}
