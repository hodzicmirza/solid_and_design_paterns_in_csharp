namespace skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Decorator;

public class CloudData : Data
{
    private string _url;

    public CloudData(string url)
    {
        _url = url;
    }

    public void Save(string data)
    {
        System.Console.WriteLine($"Saving data '{data}' to cloud at '{_url}'");
    }
}
