namespace skyline_talent_program.DIZAJN_PATERNI.KREACIJSKI_PATERNI.Builder;

public class Wheels
{
    private float _diameterInInches;

    public Wheels(float diameterInInches)
    {
        _diameterInInches = diameterInInches;
    }

    public float GetDiameterInInches()
    {
        return _diameterInInches;
    }
}
