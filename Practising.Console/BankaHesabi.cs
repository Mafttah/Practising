public class BankaHesabi
{
    private decimal _bakiye;

    public decimal Bakiye
    {
        get { return _bakiye; }
        set {
            if (value < 0)
            {
                Console.WriteLine("Hata: Bakiye negatif olamaz");
            }
            _bakiye = value;
        }
    }
    
    public void ParaYatir(decimal miktar)
    {
        if (miktar < 0) 
        {
            Console.WriteLine("Hata: Yatirilan para negatif olamaz.");
        }
        _bakiye += miktar;
        Console.WriteLine($"{miktar} £ yatitrildi. Guncellenmis bakiye {_bakiye} £");
    }

    public void ParaCek(decimal miktar)
    {
        if (miktar < 0)
        {
            Console.WriteLine("Hata: Cekilen para pozitif olmali.");
        }

        if (miktar > _bakiye)
        {
            Console.WriteLine("Hata: Yetersiz bakiye");
        }
        _bakiye -= miktar;
        Console.WriteLine($"{miktar} £ cekildi. Guncellenmis bakiye {_bakiye} £");
    }
}
