namespace skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Strategy.LosPrimjer;

public class VideoStorage
{
    private Compressors _compressor;
    private Overlays _overlay;

    public VideoStorage(Compressors compressor, Overlays overlay = Overlays.None)
    {
        this._compressor = compressor;
        this._overlay = overlay;
    }

    public void SetCompressor(Compressors newCompressor)
    {
        this._compressor = newCompressor;
    }

    public void SetOverlay(Overlays newOverlay)
    {
        this._overlay = newOverlay;
    }

    public void Store(string filename)
    { //compression logic
        if (_compressor == Compressors.MOV)
        {
            System.Console.WriteLine("Compressing using MOV");
        }
        else if (_compressor == Compressors.MP4)
        {
            System.Console.WriteLine("Compressing using MP4");
        }
        else if (_compressor == Compressors.WEBM)
        {
            System.Console.WriteLine("Compressing using WEBM");
        }

        // overlay logic
        if (_overlay == Overlays.None)
        {
            System.Console.WriteLine("Applying None overlay");
        }
        else if (_overlay == Overlays.BlackAndWhite)
        {
            System.Console.WriteLine("Applying Black and White overlay");
        }
        else if (_overlay == Overlays.Blur)
        {
            System.Console.WriteLine("Applying Blur overlay");
        }

        System.Console.WriteLine($"Storing video to {filename}.{_compressor}");
    }
}
