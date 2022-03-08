// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Kurs kurs1 = new Kurs();
kurs1.KursAdi = "C#";
kurs1.Egitmen = "Engin Demiroğ";
kurs1.IzlenmeOrani = 84;

Kurs kurs2 = new Kurs();
kurs2.KursAdi = "Java";
kurs2.Egitmen = "Kerem";
kurs2.IzlenmeOrani = 80;

Kurs kurs3 = new Kurs();
kurs3.KursAdi = "Python";
kurs3.Egitmen = "Berkay Bilgin";
kurs3.IzlenmeOrani = 90;

Kurs kurs4 = new Kurs();
kurs4.KursAdi = "C++";
kurs4.Egitmen = "Ömer Faruk";
kurs4.IzlenmeOrani = 99;



//Console.WriteLine(kurs1.KursAdi + " " +  kurs2.KursAdi+ " " + kurs3.KursAdi);

Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4};

foreach (Kurs kurs in kurslar)
{
    Console.WriteLine(kurs.KursAdi + ":" + kurs.Egitmen);
}


class Kurs
{
    public string KursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}


