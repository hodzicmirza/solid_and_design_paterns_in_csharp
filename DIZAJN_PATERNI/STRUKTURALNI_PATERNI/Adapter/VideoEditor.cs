namespace skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Adapter;

public class VideoEditor
{
    private Video _video;

    public VideoEditor(Video video)
    {
        _video = video;
    }

    public void ApplyColour(Colour color)
    {
        color.Apply(_video);
    }
}
