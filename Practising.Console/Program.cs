using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


Console.WriteLine("Alistirma 1\n");

string[] kategoriler =
{
    "Elektronik",
    "Moda",
    "Ev & Yasam",
    "Kitap",
    "Spor"
};

for (int i = 0; i < kategoriler.Length; i++)
{
    Console.WriteLine($"Kategoriler: {kategoriler[i]}\n");
}

Console.WriteLine("\nAlistirma 2\n");

int[] notlar = {65, 34, 78, 80, 35, 90, 23, 70, 55};

for (int i = 0; i < notlar.Length; i++)
{
    int not = notlar[i];
    if (not >= 50)
    {
        Console.WriteLine($"Gecer notlar: {not}\n");
    }
}


Console.WriteLine("\nAlistirma 3\n");

for (int i = 0; i <= 12; i++)
{
    for (int k = 0; k <= 15; k++)
    {
        Console.WriteLine($"{i} * {k} = {i * k}\n"); 
    }
}

Console.WriteLine("Alistirma 4\n");

string dogruSifre = "CSharp123";
string kullaniciGirdisi = null;

while (kullaniciGirdisi != dogruSifre)
{
    Console.WriteLine("Sifreyi giriniz: ");
    kullaniciGirdisi = Console.ReadLine();
}
Console.WriteLine("Giris Basarili\n");


Console.WriteLine("Alistirma 5\n");

var person1 = new Person1
{
    Ad = "Bora",
    Soyad = "Saglam",
    SicilNo = 3456,
};

person1.BilgileriYazdir();


Console.WriteLine("\nAlistirma 6\n");


var kutuphane = new List<Kitap>
{
    new Kitap("Cam Sato", "Sarah J. Maas", 100),
    new Kitap("Percy Jackson", "Rick Riordan", 200),
    new Kitap("Royal Ranger", "John Flanagan", 150),
};

//Kutuphane.KutuphaneyiGoster(kutuphane);

Console.WriteLine("\nAlistirma 7\n");

var hesap = new BankaHesabi();

hesap.Bakiye = -30;

hesap.ParaYatir(500);
hesap.ParaCek(100);

Console.WriteLine($"Guncel bakiye: {hesap.Bakiye} £");


Console.WriteLine("\nAlistirma 8\n");



Console.WriteLine("\nAlistirma 9\n");

var servis = new UrunServisi();

servis.UrunKaydet1("Bilgisayar");
servis.UrunKaydet2("Bilgisayar", 5000);
servis.UrunKaydet3("Bilgisayar", 600, 100);

servis.UrunKaydet1("Telefon");
servis.UrunKaydet2("Telefon", 3000);
servis.UrunKaydet3("Telefon", 500, 1000);

servis.UrunKaydet1("Ayakkabi");
servis.UrunKaydet2("Ayakkabi", 1000);
servis.UrunKaydet3("Ayakkabi", 100, 90000);





Console.WriteLine("\nAlistirma 10\n");

var musteri = new Musteri { MusteriAdiSoyadi = "Bora Saglam\n" };

var urun1 = new Urun { UrunAdi = "Masa", Fiyat = 900m };
var urun2 = new Urun { UrunAdi = "Bilgisayar", Fiyat = 2000m };
var urun3 = new Urun { UrunAdi = "Çanta", Fiyat = 500m };

var siparis = new Siparis
{
    SiparisNo = 2376980,
    SiparisiVerenMusteri = musteri,
    Urunler = new List<Urun> { urun1, urun2, urun3 }
};

siparis.SiparisOzetiniYazdir();











