public class Celular
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    public virtual void Ligar()
    {
        Console.WriteLine("Celular ligado.");
    }

    public virtual void Desligar()
    {
        Console.WriteLine("Celular desligado.");
    }
}

// Classes filhas (exemplos)
public class Iphone : Celular
{
    public override void Ligar()
    {
        Console.WriteLine("iPhone ligado com Face ID.");
    }
}

public class Samsung : Celular
{
    public override void Ligar()
    {
        Console.WriteLine("Samsung ligado com digital.");
    }
}

var iphone14 = new Iphone { Marca = "Apple", Modelo = "iPhone 14" };
var galaxyS23 = new Samsung { Marca = "Samsung", Modelo = "Galaxy S23" };

iphone14.Ligar(); // Saída: iPhone ligado com Face ID.
galaxyS23.Ligar(); // Saída: Samsung ligado com digital.
