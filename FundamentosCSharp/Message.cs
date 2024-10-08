
namespace FundamentosCSharp;
public class Message
{
    public string Nome { get; set; }

    public string Sobrenome { get; set; }

    public void Welcome()
    {
        Console.WriteLine($"Olá, {Nome} {Sobrenome}! Seja muito bem-vindo(a)!");
    }
}
