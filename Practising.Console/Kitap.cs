public class Kitap
{
    public string yazar;

    public string Baslik { get; set; }
    public string Yazar { get; set; }
    public double Fiyat { get; set; }

    public Kitap(string baslik, string yazar, double fiyat)
    {
        Baslik = Baslik;
        Yazar = yazar;
        Fiyat = Fiyat;
    }
}
public class Kutuphane
{
    public void KutuphaneyiGoster(List<Kitap> kitapListesi)
    {
        foreach (var k in kitapListesi)
            Console.WriteLine($"Baslik: {k.Baslik}, Yazar: {k.Yazar}, Fiyat: {k.Fiyat}");
    }
}
    



 





