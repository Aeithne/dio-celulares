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
    public virtual void FazerLigacao(string numero)
    {
        Console.WriteLine($"Ligando para {numero}...");
    }

    public virtual void EnviarMensagem(string numero, string mensagem)
    {
        Console.WriteLine($"Enviando mensagem para {numero}: {mensagem}");
    }

    public virtual void TirarFoto()
    {
        Console.WriteLine("Tirando uma foto...");
    }
}

// Classes filhas (exemplos)
public class Iphone : Celular
{
    public override void Ligar()
    {
        Console.WriteLine("iPhone ligado com Face ID.");
    }
    public void AtivarSiri()
    {
        Console.WriteLine("Ativando a Siri...");
    }
}

public class Samsung : Celular
{
    public override void Ligar()
    {
        Console.WriteLine("Samsung ligado com digital.");
    }
    public void MudarModoNoturno()
    {
        Console.WriteLine("Mudando para o modo noturno...");
    }
}

var iphone14 = new Iphone { Marca = "Apple", Modelo = "iPhone 14" };
var galaxyS23 = new Samsung { Marca = "Samsung", Modelo = "Galaxy S23" };

iphone14.Ligar(); // Saída: iPhone ligado com Face ID.
galaxyS23.Ligar(); // Saída: Samsung ligado com digital.
