using DobarUser = skyline_talent_program.SOLID.SRP.DobarPrimjer.User;
using KrugISPDobarPrimjer = skyline_talent_program.SOLID.ISP.DobarPrimjer.Krug;
using KrugISPLosPrimjer = skyline_talent_program.SOLID.ISP.LosPrimjer.Krug;
using KvadratLSP = skyline_talent_program.SOLID.LSP.LosPrimjer.Kvadrat;
using KvadratLSPDobarPrimjer = skyline_talent_program.SOLID.LSP.DobarPrimjer.Kvadrat;
using LosUser = skyline_talent_program.SOLID.SRP.LosPrimjer.User;
using PravouganoikLSP = skyline_talent_program.SOLID.LSP.LosPrimjer.Pravougaonik;
using PravougaonikLSPDobarPrimjer = skyline_talent_program.SOLID.LSP.DobarPrimjer.Pravougaonik;
using UserService = skyline_talent_program.SOLID.SRP.DobarPrimjer.UserService;

Console.WriteLine("Hello, World!");

// ENKAPSULACIJA
LosBankovniRacun losRacun = new LosBankovniRacun();
losRacun.balans = 100;

System.Console.WriteLine($"Balans na losem racunu je: {losRacun.balans}");

BankovniRacun racun = new BankovniRacun(100);
System.Console.WriteLine($"Balans na dobrom racunu je: {racun.GetStanjeRacuna()}");

racun.Deposit(200);

racun.Withdraw(300);
System.Console.WriteLine($"Balans na dobrom racunu je: {racun.GetStanjeRacuna()}");

//APSTRAKCIJA
System.Console.WriteLine("\n");
EmailServis email = new EmailServis();
email.SendMail(); // ostale funkcije su sakrivene od usera

// NASLJEDIVANJE

System.Console.WriteLine("\n");
var novoAuto = new Automobil();
novoAuto.Brend = "Porsche";
novoAuto.Model = "GT3RS";
novoAuto.Start();
novoAuto.Stop();

novoAuto.brojTockova = 4;
novoAuto.brojVrata = 2; // za biciklo ovdje ne moze jer nema tog atributa

// POLIMORFIZAM

System.Console.WriteLine("\n");
AutomobilPolimorfni polimorfnoAuto = new AutomobilPolimorfni();
polimorfnoAuto.Start();
polimorfnoAuto.Start();

List<VoziloBazna> vozila = new List<VoziloBazna>(); // da je tip liste object morali bismo imati if za svaku klasu i konverziju za svaku klasu
vozila.Add(
    new AutomobilPolimorfni
    {
        Brend = "Skoda",
        Model = "Super",
        Godina = 2022,
        brojVrata = 4,
    }
);
vozila.Add(
    new Motor
    {
        Brend = "Kawasaki",
        Model = "Ninja",
        godinaProizvodnje = 2000,
    }
);

foreach (var vozilo in vozila)
{
    System.Console.WriteLine($"{vozilo.Brend} - {vozilo.Model}");
    vozilo.Start();
    vozilo.Stop();
}

// COUPLING
System.Console.WriteLine("\n");
var narudzba = new Narudzba(new EmailSender()); // moramo poslati lokaciju gdje je intefrejs implementiran
narudzba.Naruci();

var narudzbaSMS = new Narudzba(new SMSSender()); // moramo poslati lokaciju gdje je intefrejs implementiran
narudzbaSMS.Naruci();

// KOMPOZICIJA
System.Console.WriteLine("\n");

Racunar kompjuter = new Racunar(2, 4096);
kompjuter.Upali();

// SOLID PRINCIPI -> SRP
LosUser noviKorisnik = new LosUser();
noviKorisnik.Registracija("hodzicmirza", "hodzic04mirza@gmail.com");

DobarUser noviKorisnikSRP = new DobarUser();
noviKorisnikSRP.Email = "mhodzic6@etf.unsa.ba";
noviKorisnikSRP.KorisnckoIme = "mhodzi6";

UserService userService = new UserService();
userService.Registracija(noviKorisnikSRP);

// LSP
var pravougaonik = new PravouganoikLSP();
pravougaonik.Duzina = 10;
pravougaonik.Sirina = 5;
System.Console.WriteLine($"Predvidena povrsina je: {10 * 5}");
System.Console.WriteLine($"Izracunata povrisna je: {pravougaonik.Povrsina}");

var pravougaonikLSP = new KvadratLSP();
pravougaonikLSP.Duzina = 10;
pravougaonikLSP.Sirina = 5;
System.Console.WriteLine($"Predvidena povrsina je: {10 * 5}");
System.Console.WriteLine($"Izracunata povrisna je: {pravougaonikLSP.Povrsina}");

var pravougaonikDobarPrimjer = new PravougaonikLSPDobarPrimjer();
pravougaonikDobarPrimjer.Duzina = 10;
pravougaonikDobarPrimjer.Sirina = 5;
System.Console.WriteLine($"Predvidena povrsina je: {10 * 5}");
System.Console.WriteLine($"Izracunata povrisna je: {pravougaonikDobarPrimjer.Povrsina}");

var kvadratLSPDobarPrimjer = new KvadratLSPDobarPrimjer();
kvadratLSPDobarPrimjer.DuzinaStranice = 100;
System.Console.WriteLine($"Predvidena povrsina je: {100 * 100}");
System.Console.WriteLine($"Izracunata povrisna je: {kvadratLSPDobarPrimjer.Povrsina}");

// ISP
KrugISPLosPrimjer krug = new KrugISPLosPrimjer();
krug.Radius = 4;
System.Console.WriteLine($"Povrsina {krug.Povrsina()}");

// System.Console.WriteLine($"Zapremina {krug.Zapremina()}"); desi se exception

KrugISPDobarPrimjer krugDobarPrimjer = new KrugISPDobarPrimjer();
krugDobarPrimjer.Radius = 4;
System.Console.WriteLine($"Povrsina {krugDobarPrimjer.Povrsina()}");
