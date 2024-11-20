using System;

public class Motor
{
    // Motorun özellikleri
    public int BeygirGucu { get; set; }
    public string Tur { get; set; }

    // Motorun durumu (aktif/pasif)
    private bool aktifMi;

    // Motoru başlatma metodu
    public void Baslat()
    {
        aktifMi = true;
        Console.WriteLine($"Motor başlatıldı. Beygir gücü: {BeygirGucu}, Tür: {Tur}");
    }

    // Motoru durdurma metodu
    public void Durdur()
    {
        aktifMi = false;
        Console.WriteLine("Motor durduruldu.");
    }

    // Motorun aktif olup olmadığını kontrol etme metodu
    public bool AktifMi()
    {
        return aktifMi;
    }
}

public class Araba
{
    // Arabanın özellikleri
    public string Marka { get; set; }
    public string Model { get; set; }

    // Araba sınıfı, motor nesnesini içerir
    private Motor motor;

    // Araba sınıfının yapıcı metodu
    public Araba(string marka, string model, int beygirGucu, string motorTur)
    {
        Marka = marka;
        Model = model;
        motor = new Motor { BeygirGucu = beygirGucu, Tur = motorTur };
    }

    // Araba başlatma metodu
    public void Baslat()
    {
        Console.WriteLine($"{Marka} {Model} aracı başlatılıyor...");
        motor.Baslat(); // Araba başlatıldığında motor da başlatılır
    }

    // Araba durdurma metodu
    public void Durdur()
    {
        Console.WriteLine($"{Marka} {Model} aracı durduruluyor...");
        motor.Durdur(); // Araba durdurulduğunda motor da durdurulur
    }

    // Motorun aktif durumunu kontrol etme metodu
    public bool MotorAktifMi()
    {
        return motor.AktifMi();
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Yeni bir araba oluşturuluyor
        Araba benimArabam = new Araba("Toyota", "Corolla", 130, "Benzin");

        // Araba başlatılıyor
        benimArabam.Baslat();

        // Motorun durumunu kontrol et
        Console.WriteLine($"Motor aktif mi? {benimArabam.MotorAktifMi()}");

        // Araba durduruluyor
        benimArabam.Durdur();

        // Motorun durumunu tekrar kontrol et
        Console.WriteLine($"Motor aktif mi? {benimArabam.MotorAktifMi()}");
    }
}
