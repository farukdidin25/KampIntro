// See https://aka.ms/new-console-template for more information
using OOP3;

IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager = new KonutKrediManager();

ILoggerService databaseLoggerService = new FileLoggerService();
ILoggerService loggerService = new FileLoggerService();


BasvuruManager basvuruManager = new BasvuruManager();
basvuruManager.BasvuruYap(konutKrediManager,databaseLoggerService);

List<IKrediManager> krediler = new List<IKrediManager> { konutKrediManager, ihtiyacKrediManager,tasitKrediManager};

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);
