namespace skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Flyweight;

public class CropIcon
{
    // `readonly` ensures that once constructed, they cannot be changed later on.
    private readonly CropType _type;
    private readonly byte[] _icon;

    public CropIcon(CropType type, byte[] icon)
    {
        _type = type;
        _icon = icon;
    }

    public CropType GetType()
    {
        return _type;
    }
}
