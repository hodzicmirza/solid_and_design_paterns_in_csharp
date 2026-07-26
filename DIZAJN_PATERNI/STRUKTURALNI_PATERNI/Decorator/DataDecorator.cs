namespace skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Decorator;

public abstract class DataDecorator : Data
{
    protected Data _data;

    public DataDecorator(Data data)
    {
        _data = data;
    }

    public abstract void Save(string data);
}
