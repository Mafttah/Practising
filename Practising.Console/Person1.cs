public class Person1
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int SicilNo { get; set; }

    public void BilgileriYazdir()
    {
        Console.WriteLine($"Person1: {Ad} {Soyad} {SicilNo}");
    }
}