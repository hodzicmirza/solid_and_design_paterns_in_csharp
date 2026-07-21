public class EmailServis
{
    public void SendMail()
    {
        this.Connect();
        this.Authenticate();
        System.Console.WriteLine("Sending email...");
        this.Disconnect();
    }

    private void Connect()
    {
        System.Console.WriteLine("Connecting to email server ...");
    }

    private void Authenticate()
    {
        System.Console.WriteLine("Authenticating...");
    }

    private void Disconnect()
    {
        System.Console.WriteLine("Disconnecting from email server...");
    }
}
