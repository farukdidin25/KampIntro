// See https://aka.ms/new-console-template for more information
// Do Not Repeat Yourself - DRY  <--> Best Practices
using Metotlar;

Urun urun1 = new Urun();
urun1.Id = 001;
urun1.Name = "Elma";
urun1.Fiyat = 15;
urun1.Aciklama = "Amasyanın bahçelerinden lezzetli elma";

Urun urun2=new Urun();
urun2.Id = 002;
urun2.Name = "Karpuz";
urun2.Fiyat = 25;
urun2.Aciklama = "Diyarbakır'ın sulu karpuzu";


Urun[] urunler = new Urun[] {urun1, urun2};

foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Name);
    Console.WriteLine(urun.Fiyat);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("------------------");
}


Console.WriteLine("-------------Metotlar----------------");

//instance
//encapsulation


SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1);
sepetManager.Ekle(urun2);

sepetManager.Ekle2("armut", "Yesil armut", 15);
sepetManager.Ekle2("karpuz", "diyarbakır", 25);
sepetManager.Ekle2("elma", "amasya elması", 10);




