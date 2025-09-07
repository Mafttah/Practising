public class Urun 
{
    public string UrunAdi {  get; set; }
    public decimal Fiyat { get; set; }

}

public class Musteri
{
    public string MusteriAdiSoyadi { get; set; }
}

public class Siparis
{
    public int SiparisNo { get; set; }
    public Musteri SiparisiVerenMusteri { get; set; }
    public List<Urun> Urunler {  get; set; }

    public decimal ToplamTutariHesapla()
    {
        decimal toplam = 0;
        foreach (var urun in Urunler)
            toplam += urun.Fiyat;
        return toplam;
    }

    public void SiparisOzetiniYazdir()
    {
        Console.WriteLine($"Sipariş No: {SiparisNo}");
        Console.WriteLine($"Müşteri: {SiparisiVerenMusteri.MusteriAdiSoyadi}");
        Console.WriteLine("Ürünler: ");
        foreach (var u in Urunler)
            Console.WriteLine($"{u.UrunAdi}: {u.Fiyat} £");

        Console.WriteLine($"Toplam Tutar: {ToplamTutariHesapla()} £");
    }
}



 

            

