namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Strategy.DobarPrimjer;

public class VideoStorage
{
    private ICompressor _compressor;
    private IOverlay _overlay;

    public VideoStorage(ICompressor compressor, IOverlay overlay)
    {
        this._compressor = compressor;
        this._overlay = overlay;
    }

    public void SetCompressor(ICompressor newCompressor)
    {
        this._compressor = newCompressor;
    }

    public void SetOverlay(IOverlay newOverlay)
    {
        this._overlay = newOverlay;
    }

    public void Store(string filename)
    {
        this._compressor.Compress();
        this._overlay.Apply();

        System.Console.WriteLine($"Storing file {filename}.{_compressor}");
    }
}
