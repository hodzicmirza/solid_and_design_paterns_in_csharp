namespace skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Proxy;

public class YouTubeVideo : Video
{
    private string _videoId;

    public YouTubeVideo(string videoId)
    {
        _videoId = videoId;
        Download();
    }

    private void Download()
    {
        System.Console.WriteLine("Downloading video with id " + _videoId + " from YouTube API");
    }

    public void Render()
    {
        System.Console.WriteLine("Rendering video " + _videoId);
    }

    public string GetVideoId()
    {
        return _videoId;
    }
}
