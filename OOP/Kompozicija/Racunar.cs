public class Racunar
{
    private MaticnaPloca maticna;
    private HardDisk hardDisk;
    private RAM ram;
    private Napajanje napajanje;

    public Racunar(int brojRAMPlocica, int hardDiskProstor = 1024)
    {
        this.maticna = new MaticnaPloca();
        this.hardDisk = new HardDisk(hardDiskProstor);
        this.ram = new RAM(brojRAMPlocica);
        this.napajanje = new Napajanje();
        maticna.PokreniPlocu();
    }

    public void Upali()
    {
        System.Console.WriteLine("Sistem Pokrenut");
    }
}
