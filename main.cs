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
