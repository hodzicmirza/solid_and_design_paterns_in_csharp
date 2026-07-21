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
