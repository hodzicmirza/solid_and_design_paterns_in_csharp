using skyline_talent_program;
using skyline_talent_program.DIZAJN_PATERNI.KREACIJSKI_PATERNI.AbstactFactory;
using skyline_talent_program.DIZAJN_PATERNI.KREACIJSKI_PATERNI.Builder;
using skyline_talent_program.DIZAJN_PATERNI.KREACIJSKI_PATERNI.FactoryMethod;
using skyline_talent_program.DIZAJN_PATERNI.KREACIJSKI_PATERNI.Prototype;
using skyline_talent_program.DIZAJN_PATERNI.KREACIJSKI_PATERNI.Singleton;
using skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Chain_of_Responsibillity;
using skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Command.DobarPrimjer;
using skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Interpreter;
using skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Iterator;
using skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Mediator;
using skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Memento;
using skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Observer.DobarPrimjer;
using skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.State.DobarPrimjer;
using skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Strategy.DobarPrimjer;
using skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Template.DobarPrimjer;
using skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.Visitor;
using skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Adapter;
using skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Bridge;
using skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Composite;
using skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Decorator;
using skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Facade;
using skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Flyweight;
using skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Proxy;
using DobarUser = skyline_talent_program.SOLID.SRP.DobarPrimjer.User;
using DocumentDobarPrimjer = skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.State.DobarPrimjer.Document;
using DocumentLosPrimjer = skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.State.LosPrimjer.Document;
using DocumentStatesLosPrimjer = skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.State.LosPrimjer.DocumentStates;
using KrugISPDobarPrimjer = skyline_talent_program.SOLID.ISP.DobarPrimjer.Krug;
using KrugISPLosPrimjer = skyline_talent_program.SOLID.ISP.LosPrimjer.Krug;
using KvadratLSP = skyline_talent_program.SOLID.LSP.LosPrimjer.Kvadrat;
using KvadratLSPDobarPrimjer = skyline_talent_program.SOLID.LSP.DobarPrimjer.Kvadrat;
using LosUser = skyline_talent_program.SOLID.SRP.LosPrimjer.User;
using PravouganoikLSP = skyline_talent_program.SOLID.LSP.LosPrimjer.Pravougaonik;
using PravougaonikLSPDobarPrimjer = skyline_talent_program.SOLID.LSP.DobarPrimjer.Pravougaonik;
using RemoteBridge = skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Bridge.RemoteControl;
using UserRolesDobarPrimjer = skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.State.DobarPrimjer.UserRoles;
using UserRolesLosPrimjer = skyline_talent_program.DIZAJN_PATERNI.PATERNI_PONASANJA.State.LosPrimjer.UserRoles;
using UserService = skyline_talent_program.SOLID.SRP.DobarPrimjer.UserService;
using VideoAdapter = skyline_talent_program.DIZAJN_PATERNI.STRUKTURALNI_PATERNI.Adapter.Video;

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
//
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

// MEMENTO PATTERN

System.Console.WriteLine("\n");
var editor = new Editor();
var history = new History(editor);
history.Backup();
editor.Title = "TEST";
history.Backup();
editor.Content = "Hello World, test";
history.Backup();
editor.Title = "Mirza";

System.Console.WriteLine("Title:" + editor.Title);
System.Console.WriteLine("Content:" + editor.Content);

history.Undo();
System.Console.WriteLine("Title:" + editor.Title);
System.Console.WriteLine("Content:" + editor.Content);

history.ShowHistory();

// STATE PATTERN

System.Console.WriteLine("\n");
var doc = new DocumentLosPrimjer();
doc.State = DocumentStatesLosPrimjer.Moderation;
doc.CurrentUserRole = UserRolesLosPrimjer.Editor;

System.Console.WriteLine(doc.State);

doc.Publish();
System.Console.WriteLine(doc.State);

var docDobar = new DocumentDobarPrimjer(UserRolesDobarPrimjer.Admin);
System.Console.WriteLine(docDobar.State);
docDobar.Publish();
System.Console.WriteLine(docDobar.State);
docDobar.Publish();
System.Console.WriteLine(docDobar.State);

// Strategy
System.Console.WriteLine("\n");
var videoStorage = new VideoStorage(new CompressorMOV(), new OverlayBlackAndWhite());
videoStorage.Store("/videos/test");

videoStorage.SetCompressor(new CompressorMP4());
videoStorage.SetOverlay(new OverlayNone());
videoStorage.Store("/videos/test");

// Iterator
System.Console.WriteLine("\n");

ShoppingList list = new ShoppingList();
list.Push("Mlijeko");
list.Push("Hljeb");
list.Push("Jaja");

var iterator = list.CreateIterator();

while (iterator.HasNext())
{
    System.Console.WriteLine(iterator.Current());
    iterator.Next();
}

// Command
System.Console.WriteLine("\n");

var svjetlo = new Light();

//var remote = new RemoteControl(new TurnOn(svjetlo));
//remote.PressButton();

//remote.SetCommand(new Dim(svjetlo));
//remote.PressButton();

// Template
System.Console.WriteLine("\n");

var beverageMaker = new BeverageMaker(new Tea());
beverageMaker.MakeBeverage();

beverageMaker.SetBeverage(new Coffee());
beverageMaker.MakeBeverage();

// Observer
System.Console.WriteLine("\n");

DataSource dataSource = new DataSource();

Sheet2 sheet2 = new Sheet2(dataSource);
BarChart barChart = new BarChart(dataSource);

dataSource.AddObserver(sheet2);
dataSource.AddObserver(barChart);

dataSource.SetValues([1, 2, 3, 4, 5]);

// Mediator
System.Console.WriteLine("\n");

var postDialogBox = new PostDialogBox();
postDialogBox.SimulateUserInteraction();

// Chain of Responsibillity
System.Console.WriteLine("\n");

var validator = new Validator();
var authenticator = new Authenticator();
var logger = new Logger();

validator.setNext(authenticator).setNext(logger);

var server = new WebServer(validator);
var httpRequest = new HttpRequest("mirza", "praksa");

server.Handle(httpRequest);

// Visitor
System.Console.WriteLine("\n");

var clients = new List<Client>
{
    new Retail("Mirza", "hodzic04mirza@gmail.com"),
    new Restaurant("Hodzic", "mhodzi6@etf.unsa.ba"),
    new Law("ETF", "USNA.BA"),
};

foreach (var client in clients)
{
    client.Accept(new EmailVisitor());
    client.Accept(new PDFExportVisitor());
}

// STRUKTURALNI_PATERNI -> Composite
System.Console.WriteLine("\n");

var package = new Box();

var box1 = new Box();
box1.Add(new Microphone());

var box2 = new Box();
var box3 = new Box();
box3.Add(new Mouse());

var box4 = new Box();
box4.Add(new Keyboard());

box2.Add(box3);
box2.Add(box4);

package.Add(box2);
package.Add(box1);

System.Console.WriteLine($"Total price is {package.GetPrice()}");

// Adapter
System.Console.WriteLine("\n");

var videoEditor = new VideoEditor(new VideoAdapter());
videoEditor.ApplyColour(new BlackAndWhiteColour());
videoEditor.ApplyColour(new RainbowColour(new Rainbow()));

// Bridge
System.Console.WriteLine("\n");

var LGRemoteControl = new RemoteBridge(new LGRadio());
LGRemoteControl.TurnOn();
LGRemoteControl.TurnOff();

var SONYRemote = new AdvancedRemote(new SonyRadio());
SONYRemote.SetChannel(2);

// Proxy
System.Console.WriteLine("\n");

var videoList = new VideoList();

String[] videoIds = { "1234", "abcd", "aezakmi" };

foreach (var videoId in videoIds)
{
    videoList.Add(new YouTubeVideoProxy(videoId));
}

videoList.Watch("aezakmi");

// Flyweight
System.Console.WriteLine("\n");

var cropService = new CropService(new CropIconFactory());

foreach (var crop in cropService.GetCrops())
{
    crop.Render();
}

// Facade
System.Console.WriteLine("\n");

var orderReq = new OrderRequest();

var orderService = new OrderService();

orderService.Order(orderReq);

// Decorator
System.Console.WriteLine("\n");

var url = "hodzicmirza.com";
var data = "NEKI PODACI";
var compress = true;
var encrypt = true;

Data cloudData = new CloudData(url);
cloudData = new EncryptionDecorator(cloudData);

cloudData.Save(data);

// KREACIJSKI_PATERNI -> Prototype
System.Console.WriteLine("\n");

var circle = new Circle();
circle.Draw();

circle.Radius = 12;

var rectangle = new Rectangle();
rectangle.Draw();

rectangle.Width = 12;
rectangle.Height = 20;

var shapeActions = new ShapeActions();
shapeActions.Duplicate(circle);
shapeActions.Duplicate(rectangle);

// Singleton
System.Console.WriteLine("\n");

var settings = AppSettings.GetInstance();
settings.Set("app_name", "SOLID PRINCIPI");
settings.Set("app_creator", "Mirza Hodzic");

System.Console.WriteLine($"SETTINGS: {settings.Get("app_name")}");
