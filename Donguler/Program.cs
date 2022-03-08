// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
string kurs2 = "Programlama Başlangıç İçin Temel Kurs";
string kurs3 = "Java";
string kurs4 = "Python";


string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı","Programlamaya Başlangıç İçin Temel Kurs","Java","Python"}; //arraylar



for (int i = 0; i < 4; i++)         //donguler
{
    Console.WriteLine(kurslar[i]);
}

foreach (string kur in kurslar)
{
    Console.WriteLine(kur);
}


Console.WriteLine("Sayfa Sonu");
