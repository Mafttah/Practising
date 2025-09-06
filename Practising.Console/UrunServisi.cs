public class UrunServisi
{
    public void UrunKaydet1(string urunAdi)
    {
        Console.WriteLine($"{urunAdi} adli urunun temel bilgileri kaydedildi.");
    }

    public void UrunKaydet2(string urunAdi, decimal fiyat)
    {
        Console.WriteLine($"{urunAdi}, {fiyat} £ fiyatiyla kaydedildi.");
    }

    public void UrunKaydet3(string urunAdi, decimal fiyat, int stokAdedi)
    {
        Console.WriteLine($"{urunAdi}, {fiyat} £ fiyati ve {stokAdedi} adet stok bilgisiyle kaydedildi.\n");
    }
}
    

